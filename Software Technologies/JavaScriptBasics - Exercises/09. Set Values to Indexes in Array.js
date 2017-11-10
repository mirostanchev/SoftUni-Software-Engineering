function solve(args) {
    let length = Number(args.length - 1);
    let n = Number(args[0]);

    let result = [];

    for(let i = 0; i < n; i++){
        result[i] = 0
    }

    for(let i = 1; i <= length; i++){
        let indexAndValue = args[i].split(' ')
        let index = indexAndValue[0];
        let value = indexAndValue[2];

        result[index] = value;
    }

    for(let i = 0; i < result.length; i++){
        console.log(result[i])
    }
}