package week12;

public class Emp {
	// table 컬럼명과 동일한 구성으로 자바빈 클래스 생성
	private String empmno;
	private String empname;
	private String empdept;
	private String empjob;
	private int    empsal;
	
	public Emp(String empmno, String empname, String empdept, String empjob, int empsal) {
		this.empmno = empmno;
		this.empname = empname;
		this.empdept = empdept;
		this.empjob = empjob;
		this.empsal = empsal;
	}
	
	public String getEmpmno() {
		return empmno;
	}
	public void setEmpmno(String empmno) {
		this.empmno = empmno;
	}
	public String getEmpname() {
		return empname;
	}
	public void setEmpname(String empname) {
		this.empname = empname;
	}
	public String getEmpdept() {
		return empdept;
	}
	public void setEmpdept(String empdept) {
		this.empdept = empdept;
	}
	public String getEmpjob() {
		return empjob;
	}
	public void setEmpjob(String empjob) {
		this.empjob = empjob;
	}
	public int getEmpsal() {
		return empsal;
	}
	public void setEmpsal(int empsal) {
		this.empsal = empsal;
	}

	

}
