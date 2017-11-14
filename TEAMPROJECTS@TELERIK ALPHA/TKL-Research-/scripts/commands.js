const commandsFunc = (factory, database) => {

    // Books functions
    function showView(viewName) {
        //hide all views and show the selected view only
        $("main > section").hide();
        $("#" + viewName).show();
    }

    function showEditBookView() {
        showView("viewEditBook");
    }

    function showListBooksView() {
        showView("viewListBooks");
    }

    function createBook(title, author, category, description) {
        let bookData = {
            title: $("#formCreateBook input[name=title]").val(),
            author: $("#formCreateBook input[name=author]").val(),
            category: $("#formCreateBook input[name=category]").val(),
            description: $("#formCreateBook textarea[name=descr]").val()
        };

        let book = factory.createBook(bookData.title, bookData.author, bookData.category, bookData.description);
        database.addBook(book);
        console.log(database.books);
    }

    function loadBookForEdit(id) {
    

        let books = database.returnBooks();
        console.log(books);
        console.log(id);
        let book;
        for (let b of books) {
            if (b.id == id) {
                book = b;
                console.log('found');
            }
        }
        console.log(book);
        $('#formEditBook input[name=id]').val(book.id);
        $('#formEditBook input[name=author]').val(book.author);
        $('#formEditBook input[name=title]').val(book.title);
        $('#formEditBook textarea[name=descr]').val(book.description);
        showView("viewEditBook");
    }

    function editBook(bookData){
        let books = database.returnBooks();
        for (let book of books) {
            if (book.id == bookData.id) {
                book.author = bookData.author;
                book.title = bookData.title;
                book.description = bookData.description;
            }
        }
       
       database.editBooks(books);
       listBooks();
       showListBooksView();
    }

    function deleteBook(id){
        let books = database.returnBooks();
        let index;
        for(let i = 0; i < books.length; i+=1){
            if(books[i].id==id){
                index = i;
            }
        }
        books.splice(index, 1);
        database.editBooks(books);
        listBooks();
    }

    function listBooks() {
        $('#books').empty();
        let books = database.returnBooks();
        let booksList = $('#books');
        if (books.length === 0) {
            let p = $('<p>').append('No books yet.');
            booksList.append(p);
        } else {
            let booksTable = $('<table>').append(
                $('<tr>')
                    .append('<th>#ID</th><th>Title</th><th>Author</th><th>Description</th><th>Category</th><th>Actions</th>')
            );

            for (var book of books) {

                let links = [];

                let deleteLink = $("<a href='#'>[Delete]</a>")
                .attr('id', book.id)
                .click(function (event) {
                    deleteBook(event.target.id);
                });

                let editLink = $("<a href='#'>[Edit]</a>")
                    .attr('id', book.id)
                    .click(function (event) {
                        loadBookForEdit(event.target.id);
                    });

                links.push(editLink);
                links.push(" ");
                links.push(deleteLink);

                let tableRow = $('<tr>').append(
                    $('<td>').text(book.id),
                    $('<td>').text(book.title),
                    $('<td>').text(book.author),
                    $('<td>').text(book.category),
                    $('<td>').text(book.description),
                    $("<td>").append(links)
                );
               
                booksTable.append(tableRow);
            }
            booksList.append(booksTable);
        }
    }

    // Recipies functions
    function createRecipe(title, ingredients, directions) {
        let recipeData = {
            title: $("#formCreateRecipe input[name=title]").val(),
            ingredients: $("#formCreateRecipe input[name=ingredients]").val(),
            directions: $("#formCreateRecipe textarea[name=directions]").val()
        };

        let recipe = factory.createRecipe(recipeData.title, recipeData.ingredients, recipeData.directions);
        database.addRecipe(recipe);
        console.log(database.recipe);
    }

    function listRecipes() {
        $('#recipes').empty();
        let recipes = database.returnRecipes();
        let recipesList = $('#recipes');
        if (recipes.length === 0) {
            let p = $('<p>').append('No recipes yet.');
            recipesList.append(p);
        } else {
            let recipeTable = $('<table>');
            for (var recipe of recipes) {
                let tableRow = $('<tr>').append(
                    $('<td>').text(recipe.title),
                    $('<td>').text(recipe.ingredients),
                    $('<td>').text(recipe.directions)
                );
                recipeTable.append(tableRow);
            }
            recipesList.append(recipeTable);
        }

    }

    function createComment(comment, username) {
        let commentData = {
            comment: $("#formCreateComment input[name=comment]").val(),
            username: $("#formCreateComment input[name=username]").val(),
        };

        let commentary = factory.createComment(commentData.comment, commentData.username);
        database.addComment(commentary);
        console.log(database.commentary);

        var div = document.getElementById('commentSection');
        div.innerHTML += commentData.comment;
        div.innerHTML += commentData.username;
        // let c = $('.container').append("asdasdsad");
        console.log(c);
    }

    return {
        createBook: createBook,
        editBook: editBook,
        listBooks: listBooks,
        createRecipe: createRecipe,
        createComment: createComment,
        listRecipes: listRecipes
    }
}