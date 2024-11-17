<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<H3>사원 목록</H3>
<table border="1" width="100%" style="text-align: center;">
	<tr>
		<th>사원번호</th><th>사원이름</th><th>부서코드</th><th>업무</th><th>급여</th>
	</tr>
	<c:forEach var="emp" items="${list }">
	<tr>
		<th>${emp.empno }</th>
		<th>${emp.empname }</th>
		<th>${emp.empdept }</th>
		<th>${emp.empjob }</th>
		<th>${emp.empsal }</th>
	</tr>
	</c:forEach>
</table>

<br><br>
<button onclick="location.href='main.do'">메뉴화면</button>
</body>
</html>