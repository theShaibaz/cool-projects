<?php

require_once realpath('application/libraries/dompdf/autoload.inc.php');
require_once realpath('application/libraries/dompdf/lib/html5lib/Parser.php');
require_once realpath('application/libraries/dompdf/lib/php-font-lib/src/FontLib/Autoloader.php');
require_once realpath('application/libraries/dompdf/lib/php-svg-lib/src/autoload.php');
require_once realpath('application/libraries/dompdf/src/Autoloader.php');
Dompdf\Autoloader::register();

?>
