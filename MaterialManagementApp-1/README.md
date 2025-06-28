### Updated `_Layout.cshtml`

```cshtml
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - Material Management App</title>
    <link rel="stylesheet" href="~/css/site.css" />
</head>
<body>
    <header>
        <nav>
            <ul class="nav-list">
                <li><a href="/">Home</a></li>
                <li><a href="/Materials">Materials</a></li>
            </ul>
        </nav>
    </header>
    <main role="main" class="container">
        @RenderBody()
    </main>
    <footer>
        <p>&copy; 2023 Scout Group - Material Management App</p>
    </footer>
</body>
</html>
```

### Suggested CSS Styles for `site.css`

You can add the following styles to your `site.css` file to improve the layout and appearance of your application:

```css
/* Add this to c:\Users\luigi\ScoutManager\MaterialManagementApp\wwwroot\css\site.css */

/* General Styles */
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f4f4f4;
}

header {
    background: #35424a;
    color: #ffffff;
    padding: 10px 0;
    text-align: center;
}

h1 {
    margin: 0;
}

/* Navigation Styles */
.nav-list {
    list-style-type: none;
    padding: 0;
}

.nav-list li {
    display: inline;
    margin-right: 20px;
}

.nav-list a {
    color: #ffffff;
    text-decoration: none;
    font-weight: bold;
}

.nav-list a:hover {
    text-decoration: underline;
}

/* Container Styles */
.container {
    width: 80%;
    margin: auto;
    overflow: hidden;
}

/* Table Styles */
table {
    width: 100%;
    border-collapse: collapse;
    margin: 20px 0;
}

table, th, td {
    border: 1px solid #dddddd;
}

th, td {
    padding: 8px;
    text-align: left;
}

th {
    background-color: #35424a;
    color: white;
}

/* Footer Styles */
footer {
    background: #35424a;
    color: #ffffff;
    text-align: center;
    padding: 10px 0;
    position: relative;
    bottom: 0;
    width: 100%;
}
```

### Explanation of Changes

1. **Navigation Styles**: Added a class for the navigation list to style the links horizontally and improve spacing.
2. **Hover Effects**: Added hover effects to the navigation links for better user interaction.
3. **Container Width**: Maintained a consistent width for the main content area.
4. **Table Styles**: Ensured that tables are styled for better readability.
5. **Footer Styles**: Kept the footer styling consistent with the header for a cohesive look.

These changes will help create a more visually appealing and user-friendly interface for your Material Management App. You can further customize the styles as per your group's branding or preferences.