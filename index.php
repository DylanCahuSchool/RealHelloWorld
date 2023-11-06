<?php

$helloWorld = str_split("hello world");
$alphabet = str_split("abcdefghijklmnopqrstuvwxyz");

$display = array_fill(0, 11, '');

for ($i = 0; $i < 11; $i++) {
    if ($i == 5) {
        $display[$i] = ' '; // whitespace
    } else {
        $letter = $alphabet[array_rand($alphabet)];
        while ($helloWorld[$i] != $letter) {
            $letter = $alphabet[array_rand($alphabet)];
            $display[$i] = $letter;
            echo implode($display) . "\n";
            usleep(15000); // sleep for 15 milliseconds
        }
        if ($i == 0 || $i == 6) {
            $display[$i] = strtoupper($letter); // first letter of each word in uppercase
        } else {
            $display[$i] = $letter;
        }
    }
}

echo implode($display) . "\n";

?>
