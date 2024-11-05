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

아이디: ${m.id } <br>
비밀번호: ${m.password }<br>
이름: ${m.name }<br>

<hr>
아이디: ${m.getId() } <br>
이름: ${m.getName() }<br>

<hr>
<c:if test="${m.getId() == m.getPassword() }">
	로그인 성공
</c:if>
<c:if test="${m.getId() != m.getPassword() }">
	로그인 실패
</c:if>
</body>
</html>