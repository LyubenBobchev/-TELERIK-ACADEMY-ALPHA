//3.Youngest Person

function findYoungestPerson(input) {

    function Person(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = +age;
    }

    let personArray = [];
    let minAge = Number.MAX_SAFE_INTEGER;

    for (let i = 0; i < input.length - 1; i+=3) {
        
        let firstName = input[i];
        let lastName = input[i + 1];
        let age = input[i + 2];

        let person = new Person(firstName, lastName, age);
        personArray.push(person);

        if(person.age < minAge) {
            minAge = person.age
        }
    }

    let youngest = personArray.findIndex(i => i.age === minAge);
    
    console.log(personArray[youngest].firstName + ' ' + personArray[youngest].lastName)
}

