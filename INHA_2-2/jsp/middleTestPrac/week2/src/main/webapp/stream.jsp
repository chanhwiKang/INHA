<%@page import="java.util.Arrays"%>
<%@page import="java.util.List"%>
<%@page import="week2.MemberInfo"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	List<MemberInfo> memberList = Arrays.asList(new MemberInfo("홍길동", 30),
											new MemberInfo("aaa", 22),
											new MemberInfo("bbb", 23),
											new MemberInfo("ccc", 44));
	request.setAttribute("member", memberList);
%>
	${ageList = member.stream().map(mem -> mem.age).toList();''}
	${ageList }<br>
	${member.stream().map(map -> map.age).filter(x -> x>=40).toList() }<br>
	${member.stream().map(map -> map.age).filter(x -> x>=40).average().get() }<br>
	${member.stream().filter(m -> m.age > 20).map(m -> m.age).average().get() }<br>
	${sortedMem = member.stream().sorted((x1, x2) -> x1.age > x2.age ? 1: -1).toList(); ''}<br>
	${member.stream().sorted((x1, x2) -> x1.age > x2.age ? 1: -1).map(x -> x.age).toList()}<br>
	
	${nameList = member.stream().map(x -> x.name).toList();'' }
	${nameList }
	
</body>
</html>