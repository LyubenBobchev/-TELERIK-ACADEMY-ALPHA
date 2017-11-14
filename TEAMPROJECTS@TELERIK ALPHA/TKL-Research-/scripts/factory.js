const factory = function() {

    function IDgen() {
        let id = 0;
        return (function() { return id++ }());
    }

    function createBook(title, author, category, description) {
        return {
            id: IDgen(),
            title: title,
            author: author,
            category: category,
            description: description
        }
    }

    function createRecipe(title, ingredients, directions) {
        return {
            id: IDgen(),
            title: title,
            ingredients: ingredients,
            directions: directions
        }
    }

    function createComment(comment, username) {
        return {

            comment: comment,
            username: username,
            id: IDgen(),
        }
    }

    return {
        x: console.log("factroy"),
        createBook: createBook,
        createRecipe: createRecipe,
        createComment: createComment
    }
};

// let x = [];

// x.push(factory.createBook('author', 'title', 'alala'));

// console.log(x);