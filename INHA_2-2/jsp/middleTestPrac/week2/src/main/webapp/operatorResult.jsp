<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
x = ${param.num1 }, y = ${param.num2 }<br>
x + y = ${param.num1 + param.num2 }<br>
<hr><BR>

x와 y 는 양수인가? ${param.num1 > 0 && param.num2 > 0 }<br>
x == y ? ${param.num1 == param.num2 }<br>
<hr><br>

${var = "admin" }<br>
${strArr = ['a', 'b', 'c'] }<br>
strArr = ${strArr }<br>
<hr><br>

${var=="admin" }<br>
${strArr[0] += strArr[1] += strArr[2] }<br>


</body>
</html>