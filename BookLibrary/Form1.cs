using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary
{
    public partial class Form1 : Form
    {
        private string sortColumnAuthors = "Surname";
        private bool sortAscendingAuthors = true;
        private string sortColumnBooks = "Title";
        private bool sortAscendingBooks = true;
        public Form1()
        {
            InitializeComponent();
            dataGridViewAuthor.AllowUserToOrderColumns = false;

            foreach (DataGridViewColumn column in dataGridViewAuthor.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            dataGridViewAuthor.ColumnHeaderMouseClick += dataGridViewAuthor_ColumnHeaderMouseClick;
            dataGridViewBook.AllowUserToOrderColumns = false;
            dataGridViewBook.DataBindingComplete += (s, e) =>
            {
                foreach (DataGridViewColumn column in dataGridViewBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            };
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new BookLibraryContext())
            {
                await context.Database.EnsureCreatedAsync();
            }
            await UpdateAuthors();
            await UpdateBooks();
        }


        private async Task UpdateBooks()
        {
            try
            {
                using (BookLibraryContext context = new BookLibraryContext())
                {
                    string search = textBoxSearchBooks.Text.Trim();

                    var query = context.Books
                        .Include(b => b.Author)
                        .AsQueryable();

                    if (search != "")
                    {
                        query = query.Where(b =>
                            b.Title.Contains(search) ||
                            b.Author.FirstName.Contains(search) ||
                            b.Author.Surname.Contains(search));
                    }

                    var books = await query.ToListAsync();



                    switch (sortColumnBooks)
                    {
                        case "Pages":
                            books = sortAscendingBooks
                                ? books.OrderBy(b => b.Pages).ToList()
                                : books.OrderByDescending(b => b.Pages).ToList();
                            break;

                        case "YearOfPublishing":
                            books = sortAscendingBooks
                                ? books.OrderBy(b => b.YearOfPublishing).ToList()
                                : books.OrderByDescending(b => b.YearOfPublishing).ToList();
                            break;

                        case "Price":
                            books = sortAscendingBooks
                                ? books.OrderBy(b => b.Price).ToList()
                                : books.OrderByDescending(b => b.Price).ToList();
                            break;

                        case "Genre":
                            books = sortAscendingBooks
                                ? books.OrderBy(b => b.Genre).ToList()
                                : books.OrderByDescending(b => b.Genre).ToList();
                            break;

                        case "Publisher":
                            books = sortAscendingBooks
                                ? books.OrderBy(b => b.Publisher).ToList()
                                : books.OrderByDescending(b => b.Publisher).ToList();
                            break;

                        case "Language":
                            books = sortAscendingBooks
                                ? books.OrderBy(b => b.Language).ToList()
                                : books.OrderByDescending(b => b.Language).ToList();
                            break;

                        default:
                            books = sortAscendingBooks
                                ? books.OrderBy(b => b.Title).ToList()
                                : books.OrderByDescending(b => b.Title).ToList();
                            break;
                    }



                    var result = books.Select(b => new
                    {
                        b.Id,
                        b.Title,
                        b.Pages,
                        b.YearOfPublishing,
                        b.Price,
                        b.Genre,
                        b.Publisher,
                        b.Language,
                        Author = b.Author.FirstName + " " + b.Author.Surname
                    }).ToList();

                    dataGridViewBook.DataSource = null;
                    dataGridViewBook.DataSource = result;
                    dataGridViewBook.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private object GetBookSortValue(BookLibrary.Models.Book b, string column)
        {
            switch (column)
            {
                case "Title": return b.Title ?? "";
                case "Pages": return b.Pages;
                case "YearOfPublishing": return b.YearOfPublishing;
                case "Price": return b.Price;
                case "Genre": return b.Genre ?? "";
                case "Publisher": return b.Publisher ?? "";
                case "Language": return b.Language ?? "";
                default: return b.Title ?? "";
            }
        }




        private async void dataGridViewBook_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string column = dataGridViewBook.Columns[e.ColumnIndex].DataPropertyName;

            if (sortColumnBooks == column)
                sortAscendingBooks = !sortAscendingBooks;
            else
            {
                sortColumnBooks = column;
                sortAscendingBooks = true;
            }

            await UpdateBooks();
        }



        private async Task UpdateAuthors()
        {
            try
            {
                using (BookLibraryContext context = new BookLibraryContext())
                {
                    string search = textBoxSearchAuthors.Text.Trim();

                    var query = context.Authors.AsQueryable();

                    if (search != "")
                    {
                        query = query.Where(a =>
                            a.FirstName.Contains(search) ||
                            a.Surname.Contains(search));
                    }

                    switch (sortColumnAuthors)
                    {
                        case "FirstName":
                            query = sortAscendingAuthors ? query.OrderBy(a => a.FirstName) : query.OrderByDescending(a => a.FirstName);
                            break;

                        case "DateOfBirth":
                            query = sortAscendingAuthors ? query.OrderBy(a => a.DateOfBirth) : query.OrderByDescending(a => a.DateOfBirth);
                            break;

                        case "DateOfDeath":
                            query = sortAscendingAuthors ? query.OrderBy(a => a.DateOfDeath) : query.OrderByDescending(a => a.DateOfDeath);
                            break;

                        case "CountryOfBirth":
                            query = sortAscendingAuthors ? query.OrderBy(a => a.CountryOfBirth) : query.OrderByDescending(a => a.CountryOfBirth);
                            break;

                        default:
                            query = sortAscendingAuthors ? query.OrderBy(a => a.Surname).ThenBy(a => a.FirstName) : query.OrderByDescending(a => a.Surname).ThenByDescending(a => a.FirstName);
                            break;
                    }

                    var authors = await query
                        .Select(a => new
                        {
                            a.Id,
                            a.FirstName,
                            a.Surname,
                            a.DateOfBirth,
                            a.DateOfDeath,
                            a.CountryOfBirth
                        })
                        .ToListAsync();

                    dataGridViewAuthor.DataSource = null;
                    dataGridViewAuthor.DataSource = authors;
                    dataGridViewAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні БД. {ex.Message}");
            }
        }
        private async void dataGridViewAuthor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string column = dataGridViewAuthor.Columns[e.ColumnIndex].DataPropertyName;

            if (column == "Id")
            {
                return;
            }

            if (sortColumnAuthors == column)
            {
                sortAscendingAuthors = !sortAscendingAuthors;
            }
            else
            {
                sortColumnAuthors = column;
                sortAscendingAuthors = true;
            }

            await UpdateAuthors();
        }

        private async void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            AuthorForm authorForm = new AuthorForm(author);
            if (authorForm.ShowDialog() == DialogResult.OK)
            {
                using (BookLibraryContext context = new BookLibraryContext())
                {
                    var name = await context.Authors.FirstOrDefaultAsync(a => a.FirstName == author.FirstName && a.Surname == author.Surname);
                    if (name != null)
                    {
                        MessageBox.Show("Такий автор вже існує");
                        return;
                    }
                    context.Authors.Add(author);
                    await context.SaveChangesAsync();
                    await UpdateAuthors();
                }
            }
        }

        private async void btnEditAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthor.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewAuthor.SelectedRows[0].Cells["Id"].Value.ToString(), out int authorId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Author? author = await context.Authors.FindAsync(authorId);
                        if (author != null)
                        {
                            AuthorForm authorForm = new AuthorForm(author);
                            if (authorForm.ShowDialog() == DialogResult.OK)
                            {
                                context.Entry(author).State = EntityState.Modified;
                                await context.SaveChangesAsync();
                                await UpdateAuthors();
                            }
                        }
                    }
                }
            }
        }

        private async void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthor.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewAuthor.SelectedRows[0].Cells["Id"].Value.ToString(), out int authorId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Author? author = await context.Authors.FindAsync(authorId);
                        if (author != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Do you want to delete this author?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.OK)
                            {
                                context.Entry(author).State = EntityState.Deleted;
                                await context.SaveChangesAsync();
                                await UpdateAuthors();
                            }
                        }
                    }
                }
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            BookForm bookForm = new BookForm(book);
            using (BookLibraryContext context = new BookLibraryContext())
            {
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    var title = await context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);
                    if (title != null)
                        MessageBox.Show("The book is already exists!");
                    else
                    {
                        context.Entry(book).State = EntityState.Added;
                        await context.SaveChangesAsync();
                        await UpdateBooks();
                    }
                }
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewBook.SelectedRows[0].Cells["Id"].Value.ToString(), out int bookId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Book? book = await context.Books.FindAsync(bookId);
                        if (book != null)
                        {
                            BookForm bookForm = new BookForm(book);
                            if (bookForm.ShowDialog() == DialogResult.OK)
                            {
                                context.Entry(book).State = EntityState.Modified;
                                await context.SaveChangesAsync();
                                await UpdateBooks();
                            }
                        }
                    }
                }
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridViewBook.SelectedRows[0].Cells["Id"].Value.ToString(), out int bookId))
                {
                    using (BookLibraryContext context = new BookLibraryContext())
                    {
                        Book? book = await context.Books.FindAsync(bookId);
                        if (book != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Do you want to delete this book?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.OK)
                            {
                                context.Entry(book).State = EntityState.Deleted;
                                await context.SaveChangesAsync();
                                await UpdateBooks();
                            }
                        }
                    }
                }
            }
        }

        private void textBoxSearchBooks_TextChanged(object sender, EventArgs e)
        {
            _ = UpdateBooks();
        }

        private void textBoxSearchAuthors_TextChanged(object sender, EventArgs e)
        {
            _ = UpdateAuthors();
        }

    }
}

