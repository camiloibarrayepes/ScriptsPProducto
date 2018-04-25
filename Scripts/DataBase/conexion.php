<?php

    define('DB_HOST', 'localhost');

    define('DB_USER', 'kapta998_pproduc');

    define('DB_PASSWORD', 'kapta2018');

    define('DB_DATABASE', 'kapta998_pres_producto');

    $link = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD);

    if(!$link) {

	die('Failed to connect to server: ' . mysqli_error());		

	}

						

//Select database

	$db = mysqli_select_db($link, DB_DATABASE);

	if(!$db) {

		die("Unable to select database");

	}

?>