<%@page import="java.util.Date"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

<c:set var="date" value="<%= new Date() %>"/>
[오늘 날짜] <fmt:formatDate value="${date }"/><br>
[현재 시각] <fmt:formatDate value="${date }" type="time"/><br>
<hr>
[오늘 날짜] <fmt:formatDate value="${date }" type="date" 
						  pattern="yyyy/MM/dd(E)"/><br>
[현재 시각] <fmt:formatDate value="${date }" type="time"
						  pattern="(a)hh:mm:ss"/><br>
<hr><HR>
<fmt:setLocale value="en"/>
지역 설정 변경 : 미국 <br>
[오늘 날짜] <fmt:formatDate value="${date }"/><br>
[현재 시각] <fmt:formatDate value="${date }" type="time"/><br>
<hr>
<fmt:setLocale value="ja"/>
지역 설정 변경 : 일본 <br>
[오늘 날짜] <fmt:formatDate value="${date }"/><br>
[현재 시각] <fmt:formatDate value="${date }" type="time"/><br>

</body>
</html>