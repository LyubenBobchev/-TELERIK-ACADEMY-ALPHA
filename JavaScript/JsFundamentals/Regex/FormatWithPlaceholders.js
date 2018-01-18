//1.Format with placeholders

function formatJSON(input) {

    var jsontext = '{"firstname":"Jesper","surname":"Aaberg","phone":["555-0100","555-0120"]}';
    var contact = JSON.parse(jsontext);

    console.log(contact)

}

formatJSON([
	'{ "name": "John", age: 13 }', // options as JSON
	'My name is #{name} and I am #{age}-years-old' // template
])