import React, { useEffect, useState, useCallback } from 'react';

import { BarChart, ResponsiveContainer, Bar, XAxis, YAxis, CartesianGrid, Tooltip, ReferenceLine, Cell, Legend, Brush } from "recharts";


export default function BarDuasSeries(dados) {

  const [selectedData, setSelectedData] = useState(false);
  // console.log(dados)

  const data = (dados.dados)

    const [activeIndex, setActiveIndex] = useState(0);
    const activeItem = [data[activeIndex]];

    const handleClick = useCallback(
      (entry: any, index: number) => {
        setActiveIndex(index);
      },
      [setActiveIndex]
    );

  return (
    <div className="linec">
      <label>Consumo Médio e Número de Ligações por Tipo de Econômia</label>
      <ResponsiveContainer width="99%" height={300}>
        <BarChart
          data={ selectedData ? (activeItem) : (data)}

          margin={{ top: 20, right: 0, left: -25, bottom: 0 }}
        >
          <CartesianGrid />
          <XAxis dataKey="tipo" fontSize="12" interval={0} />
          <YAxis fontSize="10" domain={[0, dataMax => (dataMax > 10000 ? dataMax /10 : dataMax)]} allowDataOverflow="false" interval="preserveStart" />
          {/* <YAxis yAxisId="right" orientation='right' fontSize="10" domain={[0, dataMax => (100) ]} allowDataOverflow="true" interval="preserveStart" /> */}

          <Tooltip />
          <Legend onClick={handleClick}/>
          <Bar dataKey="Ligações" onClick={handleClick} fill='#629F64' >
            {data.map((entry, index) => (
              <Cell cursor="pointer"
                fill='#629F64'
                key={`cell-${index}`}
                onClick={() => setSelectedData(!selectedData)} />
            ))}
          </Bar>
          <Bar dataKey="Consumo Médio" onClick={handleClick} fill='#D9AE3F'>
            {data.map((entry, index) => (
              <Cell cursor="pointer"
              
                key={`cell-${index}`}
                onClick={() => setSelectedData(!selectedData)} />
            ))}
            </Bar>
        </BarChart>
      </ResponsiveContainer>
    </div>
  );
}
