<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h3>사원 정보 조회</h3>
<form action="viewEMPQuery.jsp">
	조회할 사원번호 입력: <input type="number" name="empno"><br><br>
	<input type="submit" value="search">
	<input type="reset" value="reset">
</form>
</body>
</html>