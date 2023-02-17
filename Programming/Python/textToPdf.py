from fpdf import FPDF

pdf=FPDF()

pdf.add_page()

pdf.set.font("Arial", size= 15)

f= open("input.txt", "r")

for x in f:
	pdf.cell(200,10, txt= x, ln= 1, align ='C')

pdf.output("python.pdf")