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

        $fib0 = 1;
        $fib1 = 1;
        echo $fib0 . " ";
        for($i = 1;$i < $n;$i++){
            $next = $fib0 + $fib1;
            $fib0 = $fib1;
            $fib1 = $next;

            echo $fib0 . " ";
        }
    }
?>
</body>
</html>