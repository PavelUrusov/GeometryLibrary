using System.Text;
using Npgsql;

Console.OutputEncoding = Encoding.UTF8;
const string connectionString = "Host=localhost;Username=postgres;Password=admin;Database=psqltaskdb";
var psqlQuery = GetProductsCategoriesPsqlQuery();

using var connection = new NpgsqlConnection(connectionString);
connection.Open();

using var command = new NpgsqlCommand(psqlQuery, connection);
using var reader = command.ExecuteReader();

while (reader.Read())
{
    var productName = reader["ProductName"].ToString();
    var categoryName = reader["CategoryName"].ToString();

    Console.WriteLine($"ProductName: {productName}, CategoryName: {categoryName}");
}

return;

string GetProductsCategoriesPsqlQuery()
{
    return @"
        SELECT
            p.product_name AS ProductName,
            c.category_name AS CategoryName
        FROM
            products p
        LEFT JOIN
            product_categories pc ON p.product_id = pc.product_id
        LEFT JOIN
            categories c ON pc.category_id = c.category_id;";
}

void CreateProductCategoryTables(string connectionString)
{
    var createTables = @"
            CREATE TABLE products (
                product_id SERIAL PRIMARY KEY,
                product_name VARCHAR(255) NOT NULL
            );

            CREATE TABLE categories (
               category_id SERIAL PRIMARY KEY,
               category_name VARCHAR(255) NOT NULL
            );

            CREATE TABLE product_categories (
                product_id INT REFERENCES products(product_id),
                category_id INT REFERENCES categories(category_id),
                PRIMARY KEY (product_id, category_id)
           );";
    using var connection = new NpgsqlConnection(connectionString);
    using (var command = new NpgsqlCommand(createTables, connection))
    {
        command.ExecuteNonQuery();
    }

    Console.WriteLine("Tables have been created successfully!");
}