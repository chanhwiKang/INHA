<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<script type="text/javascript">
	function check() {
		if (!frm.empno.value){
			alert("사원번호를 입력하세요");
			frm.empno.focus();
			return false;
		}
		if (!frm.empname.value){
			alert("사원이름을 입력하세요");
			frm.empname.focus();
			return false;
		}
	}

</script>


<h3>사원 등록 화면</h3>
<form action="inputEmpConfirm.do" name="frm" onsubmit="return check()">
	<table border="1">
		<tr>
			<td>사원 번호</td>
			<td><input type="text" name="empno" autofocus="autofocus"></td>
		</tr>
		<tr>
			<td>사원 이름</td>
			<td><input type="text" name="empname"></td>
		</tr>
		<tr>
			<td>부서 코드</td>
			<td><input type="text" name="empdept"></td>
		</tr>
		<tr>
			<td>업무</td>
			<td><input type="text" name="empjob"></td>
		</tr>
		<tr>
			<td>급여</td>
			<td><input type="number" name="empsal"></td>
		</tr>
	</table>
	<br><BR>
	<input type="submit" value="register">
	<input type="reset" value="reset">
</form>

<button onclick="location.href='main.do'">메뉴화면</button>

</body>
</html>