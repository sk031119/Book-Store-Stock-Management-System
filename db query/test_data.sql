INSERT INTO
  Users (Username, PASSWORD, Role)
VALUES
  ('admin', 'password', 'ADMIN'),
  ('user', 'pwd', 'EMPLOYEE');

INSERT INTO
  Authors (FirstName, LastName)
VALUES
  ('George', 'Orwell'),
  ('Jane', 'Austen'),
  ('J.K.', 'Rowling');

INSERT INTO
  Categories (CategoryName)
VALUES
  ('Fiction'),
  ('Romance'),
  ('Fantasy');

INSERT INTO
  Publishers (Name, Phone, Address, ContactPerson)
VALUES
  (
    'Penguin Books',
    '123456789',
    '123 Penguin Lane',
    'John Doe'
  ),
  (
    'HarperCollins',
    '987654321',
    '456 Harper Ave',
    'Jane Smith'
  );

INSERT INTO
  Supplier (Name, Phone, Address, ContactPerson)
VALUES
  (
    'BookSupplier Co',
    '111222333',
    '789 Supply St',
    'Michael Scott'
  );

INSERT INTO
  Books (
    ISBN,
    Title,
    RetailPrice,
    StockCount,
    StockStatus,
    AuthorId,
    CategoryId,
    PublisherId
  )
VALUES
  (
    9780451524935,
    '1984',
    15.99,
    50,
    'out-of-stock',
    1,
    1,
    1
  ),
  (
    9780141439518,
    'Pride and Prejudice',
    12.50,
    30,
    'in-stock',
    2,
    2,
    1
  ),
  (
    9780747532743,
    'Harry Potter and the Philosopher''s Stone',
    19.99,
    100,
    'low-stock',
    3,
    3,
    2
  );