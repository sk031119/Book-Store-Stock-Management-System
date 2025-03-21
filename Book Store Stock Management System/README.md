# Book Store Stock Management System

**Objective**

To develop a user-friendly book inventory management system where users can manage books, authors, categories, and publishers efficiently.

**Overall Functionalities**

- **User Authentication**

  - Login system with role-based access (Admin & Employee)

  - Different UI based on user role

- **Book Management**

  - View, add, edit, and delete books (Admin only)

  - Employees can only view book listings

  - Stock Status Indicator: Books will have a status color to indicate stock levels:

    - Green: Sufficient stock available

    - Yellow: Low stock

    - Red: Critical stock level (needs restocking)

- Author Management

  - View, add, edit, and delete authors (Admin only)

- Category Management

  - View, add, edit, and delete categories (Admin only)

- Publisher Management\
  View, add, edit, and delete publishers (Admin only)

- Stock Monitoring

  - View stock levels for each book

  - Notifications for low stock books (Admin only)

  - Stock status visually indicated for easy tracking

- Reports & Insights

  - Admin can access stock analytics

  - Employees can only view stock availability

**Wireframe or UI Concept**

A structured wireframe will be designed to outline the UI flow. The key sections include:

- Login Page – Allows users to log in as Admin or Employee

- Admin Dashboard – Full access to book management, reports, and inventory control

- Employee Dashboard – Limited access, primarily for viewing stock information

- Books Section – Displays a list of books with relevant details and stock levels

  - Stock Status will be color-coded (Green, Yellow, Red) for easy monitoring

- Reports Section – Admin-exclusive for viewing analytics

**Operations**

- Role-based UI Navigation: Different features are accessible based on user roles

- Data Representation: Display books and stock levels in a structured table

- Search & Filter Options: Users can filter books by category, author, or publisher

- Interactive UI: Seamless navigation and user-friendly interactions

- Stock Alerts: Low stock notifications for Admins based on predefined stock limits

**Specification - How It Works**

- Users log in and are redirected based on their role

- Admins have CRUD (Create, Read, Update, Delete) access for books, authors, publishers, and categories

- Employees can only view stock and book listings

- Stock monitoring ensures admin can track inventory and receive alerts for low stock

- Books will be displayed with stock status indicators (Green, Yellow, Red)

**Instructor Notes - User Guide**

- Login Process: Users log in and are redirected based on their role

- Book Management: Admins can modify book details while employees can only view

- Navigation: Intuitive tab-based layout for managing books, authors, and categories

- Stock Management: Admins can track inventory and receive alerts for low stock

- Stock Status Indicator: Helps users quickly determine stock levels and take necessary actions
