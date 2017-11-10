function solve(args) {
    let x = Number(args[0])
    let y = Number(args[1])
    let z = Number(args[2])

    if(x === 0 || y === 0 || z === 0){
        console.log('Positive')
    }else{
        let counter = 0;

        if(x < 0){
            counter++;
        }
        if(y < 0){
            counter++;
        }
        if(z < 0){
            counter++;
        }

        if(counter % 2 === 0){
            console.log('Positive')
        }else{
            console.log('Negative')
        }
    }
}