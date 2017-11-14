// TODO fix listing so it works for html

const databaseFunction = function () {
    let books = [];
    let recipes = [];
    let comments = [];

    const returnBooks = function () {

        return books;
    }
    const returnRecipes = function () {

        return recipes;
    }

    const addBook = function (obj) {
        books.push(obj);
    };

    const listBooks = function () {
        console.log(books);
    };

    const editBooks = function (arr) {
        books = arr;
        console.log('books edited');
        console.log(books);
    }

    const addRecipe = function (obj) {
        recipes.push(obj);
    };
    const addComment = function (obj) {
        comments.push(obj);
    }

    const listRecipes = function () {
        console.log(recipes);
    };

    return {
        x: console.log('data'),
        books: books,
        recipes: recipes,
        addBook: addBook,
        listBooks: listBooks,
        editBooks: editBooks,
        addRecipe: addRecipe,
        addComment: addComment,
        listRecipes: listRecipes,
        returnBooks: returnBooks,
        returnRecipes: returnRecipes
    }
};

// database.addBook({name:'book1'});
// database.listBooks();