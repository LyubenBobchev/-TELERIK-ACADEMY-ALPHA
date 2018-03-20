//2.Game of Trolls

function solve(args) {
    let fieldDimensions = args[0].split(' ');

    //creating the field via 2dimension array
    let fieldRows = +fieldDimensions[0];
    let fieldCols = +fieldDimensions[1];
    let fieldArray = new Array(fieldRows);

    function createField(rows, cols) {
        var field = new Array(rows)

        for (var i = 0; i < rows; i++) {
            field[i] = new Array(cols)
            for (let j = 0; j < field.length; j++) {
                field[i][j] = false;
            }
        }
        return field;
    }

    let field = createField(fieldRows, fieldCols);

    //checking if troll is trapped
    function isTrapped(row, col) {
        if (field[row][col] === true) {
            return true;
        } else {
            return false;
        }
    }

    //TODO:checking if princess is caught
    function isCaught(princessPossR,princessPossC, trollPossR,trollPossC) {

        if (princessPossR === trollPossR) {
            
        }
    }
    //TODO:checking if princess is saved

    //Princes char
    function Princess(positionR, positionC, name, isCaught) {
        this.positionR = positionR;
        this.positionC = positionC;
        this.name = name;
        this.isCaught = isCaught;
    }
    //troll char
    function Troll(positionR, positionC, name, isTrapped) {
        this.positionR = positionR;
        this.positionC = positionC;
        this.name = name;
        this.isTrapped = isTrapped;
    }
    //creating characters
    let characterSet = [];

    let positionParams = args[1].split(';');
    let wTrollPos = positionParams[0].split(' ').map(Number);
    let nTrollPos = positionParams[1].split(' ').map(Number);
    let lPrincessPoss = positionParams[2].split(' ').map(Number);

    characterSet.push(new Troll(wTrollPos[0], wTrollPos[1], "Wboup", false));
    characterSet.push(new Troll(nTrollPos[0], nTrollPos[1], "Nbslbub ", false));
    characterSet.push(new Princess(lPrincessPoss[0], lPrincessPoss[1], "Lsjtujzbo", false));

    //move loop
    for (let i = 2; i < args.length; i++) {
        //spliting instructions
        let instructions = args[i].split(' ')
        let action = instructions[0];

        //moving the correct character
        if (action === 'mv') {
            let characterToAct = instructions[1];
            let directionToMove = instructions[2];

            characterSet.forEach(character => {
                if (character.name === characterToAct && (character.isTrapped !== true)) {
                    try {
                        switch (directionToMove) {
                            case 'u':
                                character.positionR += 1;
                                break;
                            case 'd':
                                character.positionR -= 1;
                                break;
                            case 'l':
                                character.positionC -= 1;
                                break;
                            case 'r':
                                character.positionC += 1;
                                break;

                            default:
                                break;
                        }
                    } catch (error) {
                    }
                }
            });
        } else if (action === 'lay') { //laying a trap
            let princess = characterSet[2];
            field[princess.positionR][princess.positionC] = true;
        }
    }
    //checking state of the game after move
    characterSet.forEach(character => {
        //checking if trolls are trapped
        if (isTrapped(character.positionR, character.positionC) && character.name !== 'Lsjtujzbo') { //traping trolls
            character.isTrapped = true;
            field[character.positionR][character.positionC] = false;
        }
        
    });

}

solve([
    '5 5',
    '1 1;0 1;2 3',
    'mv Lsjtujzbo d',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Wboup r',
    'mv Wboup r',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d'
]);
// //matrix 5x5
// var items = [
//     [0, 1, 2, 3, 4],
//     [5, 6, 7, 8, 9],
//     [10, 11, 12, 13, 14],
//     [15, 16, 17, 18, 19],
//     [20, 21, 22, 23, 24]
// ];
//     // console.log(items[1][1]); // 1
//     // console.log(items);