# The Reading Room - Phase 1

This is the Windows Forms desktop phase of the bookstore management project. It uses in-memory data only. Books, categories, sales, registered cashier accounts, and settings reset when the application closes. Database/API and web work belong to later phases and are not included here.

## Open and run

1. Open `THE READING ROOM.slnx` in Visual Studio 2026.
2. Select the `THE READING ROOM` project as the startup project if needed.
3. Build and run on Windows with the .NET 10 SDK and .NET desktop development workload installed.

## Demo sign-in

- Administrator: `admin` / `admin123`
- Cashier: `cashier` / `cashier123`

New accounts are Cashier accounts and remain in memory until the application closes.

## Phase-one features

- Dashboard with live inventory, monthly sales, low-stock, and activity summaries
- Book catalogue with add, edit, delete, search, category and stock filters, and helpful empty states
- Category management with duplicate-name checks and a safeguard against deleting categories that still have books
- Multi-book checkout with stock validation, optional walk-in customer, basket management, and a receipt-style confirmation
- Reports for all books, sales in a selected date range, and low-stock books; sales can be exported to CSV
- Settings for the low-stock level, loading sample data, and clearing in-memory records
- Event-driven navigation, validation feedback, menu actions, and status-bar updates
- Bookstore photography on the welcome, login, registration, and main navigation screens
- A small, smooth hover animation on the dashboard bookshelf illustration

The low-stock report uses a Windows Forms `ListView`, as required by the instructor's core desktop requirements. The shared bookshelf PictureBox and dashboard animation timer are exposed in the Visual Studio Designer for visual editing.
