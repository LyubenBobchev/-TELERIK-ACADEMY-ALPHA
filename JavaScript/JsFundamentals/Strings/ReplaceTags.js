//8.Replace tags

//TODO:FINISH THIS
function replaceTags(input) {

    let regex = /(<a href=[a-z":\/.>/ ]*)/g;
    let splitRegex = /[a-z\/.:]*/g;
    let test = /,/g;
    let regexa = /[a-z]*/g;

    let match = input[0].match(regex).toString();
    let splitString = match.match(splitRegex).toString();
    let replaceString = splitString.replace(test,' ')
    let final = replaceString.match(regexa);
    
    console.log(final);
}

replaceTags(['<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>']);

