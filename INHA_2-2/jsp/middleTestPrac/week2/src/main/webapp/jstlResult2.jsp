<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
id: ${m.id }<br>
name: ${m.name }<br><br>

<c:if test="${m.id == m.password}">
	로그인 성공 
</c:if>
<c:if test="${m.id != m.password }">
	로그인 실패
</c:if>
</body>
</html>