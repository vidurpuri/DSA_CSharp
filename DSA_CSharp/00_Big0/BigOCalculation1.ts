// WHat is the Big O of below function ?
function funChallenge(input) {
    let a = 10; //O(1)
    a = 50 + 3; //O(1)

    for (let i = 0; i < input.length; i++) { //O(n)
        anotherFunction(); //O(n)
        let stranger = true; //O(n)
        a++; //O(n)
    }

    return a; //O(1)
}

function anotherFunction() {
    console.log('anotherFunction');
}

// Result Big (0)

// Case 1 : Line 3,4,12 will be O(1) as these are one time operation and does not depend on parameter/input
// Case 2 : Line 6-10 is O(n) as these will exaxt number of times as we have elements in input.

// So Big O = (3 + 4n) = O(n)
