# GeometryLibrary

## Overview

GeometryLibrary is a versatile library for calculating the area of various geometric shapes. It offers a set of shape classes,each with its own area calculation strategy. The library is designed to be user-friendly and extensible, allowing users to effortlessly compute the area of different shapes.

## Prerequisites

Before using the library,  ensure that you have the following prerequisites:

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed
## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Examples](#examples)
- [SQL Query](#sql-query)

## Installation

1. Clone the repository:
   ```shell
   git clone https://github.com/PavelUrusov/GeometryLibrary.git
   d
2. Build the solution:
    ```shell
    cd GeometryLibrary
    dotnet build

# Usage

The library provides a Geometry Calculator class that implements the IGeometryCalculatorArea interface. This class is responsible for calculating the area of a given shape. The shape classes implement the IShape interface, and each shape has its own area calculation strategy.

## Examples

```C#
using GeometryLibrary.Logic.Services;
using GeometryLibrary.Logic.Shapes;

var ships = new List<IShape>
{
    new Circle(10),
    new Square(4),
    new Triangle(3, 4, 5)
};

var calc = new GeometryCalculator();

foreach (var ship in ships)
{
    Console.WriteLine($"Ship:{ship.ToString()}, Area: {calc.CalculateArea(ship)}");
}
```

## SQL Query

For the SQL query to retrieve all pairs of "Product Name - Category Name," you can use the following query:

```sql
SELECT
    p.product_name AS ProductName,
    c.category_name AS CategoryName
FROM
    products p
LEFT JOIN
    product_categories pc ON p.product_id = pc.product_id
LEFT JOIN
    categories c ON pc.category_id = c.category_id;
```

This query selects the product name and category name from the products, product_categories, and categories tables, even if a product doesn't have a category.

