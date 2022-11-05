Write-Host "Welcome to The PowerShell Calculator"
[int]$firstNum= Read-Host -Prompt "Input your first number `n"
[int]$secondNum= Read-Host -Prompt "Input your second number `n"
$operator= Read-Host -Prompt "Input your desired Operator ( + | - | * | / )"
if ( $operator -eq "+" )
{
    $sum= $firstNum + $secondNum
}
if ( $operator -eq "-" )
{
    $sum= $firstNum - $secondNum
}
if ( $operator -eq "*" )
{
    $sum= $firstNum + $secondNum
}
if ( $operator -eq "/" )
{
    $sum= $firstNum / $secondNum
}

$sum

