import React from "react";
import { useReactToPrint } from "react-to-print";
import { useRef } from "react";
import { WorkoutPDF } from "./workoutPDF";

const HandlePrint = () => {
  const componentRef = useRef(null);
  const handlePrint = useReactToPrint({
    content: () => componentRef.current,
  });
  return (
    <div>
      <button onClick={handlePrint}>Print this out!</button>
      <div style={{ display: "none" }}>
        {" "}
        <WorkoutPDF ref={componentRef} />
      </div>
    </div>
  );
};

export default HandlePrint;
