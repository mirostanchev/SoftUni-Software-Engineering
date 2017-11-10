function solve(args) {
    let length = args.length;
    let result = [];

    for(let i = 0; i < length; i++){
        let num = Number(args[i]);

        result.push(num);
    }

    for(let i = result.length - 1; i >= 0;i--){
        console.log(result[i])
    }
}