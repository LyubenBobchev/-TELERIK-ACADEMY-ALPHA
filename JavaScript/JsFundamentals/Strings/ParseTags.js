//4.Parse tags

//TODO:Finish this

function parseTags(input) {

    let re = /<upcase>/g;
        
    console.log(input.split(re));

}


parseTags('We are <upcase>asdasd<orgcase>liViNg</orgcase>asdasd</upcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.')