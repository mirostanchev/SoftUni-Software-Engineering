function solve(args) {
    let length = Number(args.length);

    let result = [];

    for(let i = 0; i < length; i++){
        let commandInfo = args[i].split(' ');
        let command = commandInfo[0];

        if(command === 'add'){
            let element = commandInfo[1];
            result.push(element);
        }else if(command === 'remove'){
            let index = Number(commandInfo[1]);
            result.splice(index,1);
        }
    }

    for(let i = 0; i < result.length; i++){
        console.log(result[i])
    }
}