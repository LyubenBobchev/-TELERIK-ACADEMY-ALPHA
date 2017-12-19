//11.Parse URL

function parseUrl(input) {

    let urlSplit = input[0].split('/');
    let protocol = urlSplit[0].replace(':','');
    let server = urlSplit[2];

    let resource = function resources() {
        let resourceString = '';
        for (let i = 3; i < urlSplit.length; i++) {
                     resourceString += '/' + urlSplit[i];  
        }

        return resourceString;
    }


    console.log('protocol:' + ' ' + protocol);
    console.log('server:'+' '+ server);
    console.log('resource:'+' '+ resource());

}

parseUrl(['http://telerikacademy.com/Courses/Courses/Details/239']);