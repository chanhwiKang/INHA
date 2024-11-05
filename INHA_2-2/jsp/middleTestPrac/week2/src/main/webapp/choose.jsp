<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %><!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<ul>
	<c:choose>
		<c:when test="${m.name == '홍길동' }">
			<li>당신의 이름은 ${m.name}
		</c:when>
		<c:when test="${m.age > 20 }">
			<li>you are older then 20
		</c:when>
		<c:otherwise>
			<li>adasdasd
		</c:otherwise>
	</c:choose>
</ul>
</body>
</html>