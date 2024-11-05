<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

<!-- java 기준 MemberInfo member = new MemberInfo(); 와 동일 -->
<jsp:useBean id="member" class="week5.MemberInfo" scope="request"/>
<jsp:setProperty property="id" name="member" value="admin"/>
<jsp:setProperty property="name" name="member" value="Hong"/>
<jsp:setProperty property="email" name="member" value="email@abc.com"/>

<jsp:forward page="useObject.jsp" />

</body>
</html>