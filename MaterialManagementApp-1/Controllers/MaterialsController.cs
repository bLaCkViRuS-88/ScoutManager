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