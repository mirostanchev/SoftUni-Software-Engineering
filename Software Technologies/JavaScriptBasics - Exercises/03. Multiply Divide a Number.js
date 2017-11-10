function solve(args) {
    let n = Number(args[0])
    let x = Number(args[1])

    let result = 0;

    if(x >= n){
        result = x * n;
    }else{
        result = n / x;
    }

    console.log(result)
}