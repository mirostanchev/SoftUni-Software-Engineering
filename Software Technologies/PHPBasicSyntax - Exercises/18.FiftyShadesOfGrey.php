<?php

$first = 0;
for ($row = 1;$row <=5;$row++){
    for ($col = 1;$col<= 10;$col++){
        echo "<div style=\"background-color: rgb($first, $first, $first);\"></div>";
        $first += 5;
    }
    $first++;
    echo '<br>';
}
?>