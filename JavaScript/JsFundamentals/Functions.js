//1.Say Hello

function sayHello(name) {
    console.log(`Hello, ${name}!`)
}

//2. Get largest number

function getLargestNum(input) {

    let nums = (input.split(' '));
    let parsedNums = [];
    for (var key in nums) {
       parsedNums[key] = parseInt(nums[key]);
    }
    console.log(Math.max.apply(null,parsedNums))
}
getLargestNum('7 19 19');