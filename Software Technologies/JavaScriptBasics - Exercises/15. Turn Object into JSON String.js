function solve(args) {
    let studentData = args.map(s => s.split(' -> '));
    let student = {};

    studentData.forEach(tokens => {
        let key = tokens[0];
        let value = tokens[1];

        if(key === 'age' || key === 'grade'){
            value = Number(value);
        }
        student[key] = value;
    })

    console.log(JSON.stringify(student));
}