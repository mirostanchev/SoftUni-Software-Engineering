function JSONObjects(input) {
    for (let i = 0; i < input.length; i++) {
        let result = JSON.parse(input[i])
        console.log(`Name: ${result.name}`)
        console.log(`Age: ${result.age}`)
        console.log(`Date: ${result.date}`)
    }
}