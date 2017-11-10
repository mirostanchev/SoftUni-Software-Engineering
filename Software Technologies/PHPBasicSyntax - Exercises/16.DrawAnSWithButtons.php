<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
    <?php
        $rows = 9;
        $cols = 5;

        for ($row = 1; $row <= $rows;$row++){

            for($col = 1;$col<= $cols;$col++){
                if ($row == 1 || $row == 5 || $row == 9){
                    echo "<button style='background-color: blue'>1</button>";
                }
                else{
                    if($row >= 2 && $row <= 4 && $col == 1){
                        echo "<button style='background-color: blue'>1</button>";
                    }
                    if($row >= 2 && $row <= 4 && $col >= 2 && $col <= 5){
                        echo "<button>0</button>";
                    }
                    if($row >= 6 && $row <= 8 && $col >= 1 && $col <= 4){
                        echo "<button>0</button>";
                    }
                    if($row >= 6 && $row <= 8 && $col == 5){
                        echo "<button style='background-color: blue'>1</button>";
                    }
                }

            }
            echo "<br />";
        }
    ?>
</body>
</html>