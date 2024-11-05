<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<jsp:useBean id="member" class="week2.MemberInfo" scope="request"/>
<jsp:setProperty property="id" name="member" value="admin"/>
<jsp:setProperty property="name" name="member" value="홍길동"/>
<jsp:setProperty property="email" name="member" value="admin@asd.fg"/>

<jsp:forward page="useObject.jsp"/>
</body>
</html>