// What is the big O of Below function ?

function anotherFunChallenge(input) {
    let a = 5; //O(1)
    let b = 10;//O(1)
    let c = 20;//O(1)

    for (let i = 0; i < input.length; i++) {//O(n)
        let x = i + 1;//O(n)
        let y = i + 2;//O(n)
        let z = i + 3;//O(n)
    }

    for (let j = 0; j < input.length; j++) {//O(n)
        let p = j * 2;//O(n)
        let q = j * 2;//O(n)
    }

    let whoAmI = "i Dont Know"; //O(1)
}

//Resut Big O = 4 + 7n = O(n)