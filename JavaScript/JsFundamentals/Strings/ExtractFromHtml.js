//6.Extract from html

function extractFromHtml(input) {

    let regex =/<(?:.|\n)*?>/gm
    
    
    return input.toString().split(regex);

}

let test = [
	'<html>',
	'  <head>',
	'    <title>Sample site</title>',
	'  </head>',
	'  <body>',
	'    <div>text',
	'      <div>more text</div>',
	'      and more...',
	'    </div>',
	'    in body',
	'  </body>',
	'</html>'
]

console.log(extractFromHtml(test));