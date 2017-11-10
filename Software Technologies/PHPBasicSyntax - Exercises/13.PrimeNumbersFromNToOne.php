<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    X: <input type="text" name="num" />
    <input type="submit" />
</form>

<?php
    if (isset($_GET['num'])){
        $n = intval($_GET['num']);

        for($i = $n; $i >= 3;$i--){
            $isPrime = true;
            $num = $i;

            for($j = 2; $j < $i;$j++){
                if ($num % $j == 0){
                    $isPrime = false;
                }
            }

            if ($isPrime){
                echo $num . " ";
            }

        }
    }
?>
</body>
</html>