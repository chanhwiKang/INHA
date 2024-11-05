<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	${varList = [2, 11, 7, 4, 8, 5];'' }
	${varList.stream().sum() }<br>
	${varList.stream().max().get() }<br>
	${varList.stream().min().get() }<br>
	${varList.stream().average().get() }<br>
	${varList.stream().count() }<br>
	${varList.stream().sorted().toList() }<br>
</body>
</html>