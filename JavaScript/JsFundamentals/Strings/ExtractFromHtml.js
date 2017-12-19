//6.Extract from html

function solve(args) {
    var i = 0,
        regex = /<(.*?)>/g,
        result = '';

    for (i; i < args.length; i += 1) {
        result += args[i].trim().replace(regex, '').trim();
    }

    console.log(result);
}