import React from "react";
import { PDFViewer, Document, Text, Page } from "@react-pdf/renderer";

const pdf = {
  size: {
  width: "21cm",
  height: "29.7cm",
  padding: "1cm"
  },
  header: {
fontSize: "48px",
marginLeft: "48px",
marginTop: "48px",
fontDecoration: "underline",
  },

  footer: {},




}


export class WorkoutPDF extends React.PureComponent {


  render() {
    return (
      <div style={pdf.size}>
        <div style={pdf.header}>This is a headline</div>
          <div>Text här</div>
        
      </div>
    );
  }
}
