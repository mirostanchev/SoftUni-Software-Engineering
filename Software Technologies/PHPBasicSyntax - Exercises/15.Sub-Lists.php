<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    X: <input type="text" name="num1" />
    Y: <input type="text" name="num2" />
    <input type="submit" />
</form>
<ul>
    <?php
        if (isset($_GET['num1']) && isset($_GET['num2'])){
            $x = intval($_GET['num1']);
            $y = intval($_GET['num2']);

            for ($i = 1;$i <= $x;$i++){
                echo "<li>";
                echo "List $i";

                echo "<ul>";
                for ($j = 1;$j <= $y;$j++){
                    echo "<li>";
                    echo "Element $i.$j";
                    echo "</li>";
                }
                echo "</ul>";

                echo "</li>";
            }
        }
    ?>
</ul>
</body>
</html>