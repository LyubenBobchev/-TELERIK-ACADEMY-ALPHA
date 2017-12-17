//2.Remove elements

function removeFirstElement(input) {

    Array.prototype.removeElement = function () {

        return this.filter(e => e !== this[0])
    }

    var changedArray = input.removeElement();
    
    changedArray.forEach(element => {
        console.log(element);
    });
}
