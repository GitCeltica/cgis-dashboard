(this["webpackJsonpreact-dashboard"]=this["webpackJsonpreact-dashboard"]||[]).push([[0],{363:function(e,t,a){},364:function(e,t,a){},365:function(e,t,a){"use strict";a.r(t);var n=a(0),c=a.n(n),s=a(53),r=a.n(s),i=a(3),o=a(43),l=a(19),d=a(102),j=a(193),u=a(1);function b(e){var t=e.component,a=(e.isPrivate,Object(j.a)(e,["component","isPrivate"]));return Object(u.jsx)(l.a,Object(d.a)(Object(d.a)({},a),{},{render:function(e){return Object(u.jsx)(t,Object(d.a)({},e))}}))}var O=a.p+"static/media/wellcomemsg.3ffca511.svg";function m(){return Object(u.jsx)("div",{className:"content",children:Object(u.jsx)("h1",{className:"nodata",children:Object(u.jsx)("img",{className:"loginMsg",src:O,alt:"Bem-vindo"})})})}var h=a(21),f=a.n(h),p=a(37),v=a(366),x=a(367),g=a(371),N=a(97),S=a(98),w=a(80),L=a(185),C=a(187),E=a(178);function y(e){var t=Object(n.useState)(!1),a=Object(i.a)(t,2),c=a[0],s=a[1],r=Object(n.useState)(!1),o=Object(i.a)(r,2),l=o[0],d=o[1],j=e.dados,b=j.data.reduce((function(e,t){return e+t.valor}),0)/j.data.length,O=Object(n.useState)(""),m=Object(i.a)(O,2),h=(m[0],m[1],Object(n.useState)(0)),f=Object(i.a)(h,2),p=f[0],y=f[1],k=[j.data[p]],z=Object(n.useCallback)((function(e,t){y(t)}),[y]);return Object(u.jsxs)("div",{className:"barc",children:[Object(u.jsx)("label",{children:j.name}),Object(u.jsx)(v.a,{height:200,children:Object(u.jsxs)(x.a,{data:c?k:j.data,margin:{top:20,right:0,left:-25,bottom:0},children:[Object(u.jsx)(g.a,{}),Object(u.jsx)(N.a,{dataKey:"name",fontSize:"12",interval:0}),Object(u.jsx)(S.a,{fontSize:"10"}),Object(u.jsx)(w.a,{}),Object(u.jsx)(L.a,{dataKey:"valor",onClick:z,children:j.data.map((function(e,t){return Object(u.jsx)(C.a,{cursor:"pointer",fill:"#375E65",onClick:function(){return s(!c)}},"cell-".concat(t))}))}),1!==j.data.length&&!1===l?Object(u.jsx)(E.a,{y:b,stroke:"#B14545",strokeWidth:"3",position:"right",ifOverflow:"extendDomain"}):null]})}),Object(u.jsxs)("div",{className:"legenda",children:[Object(u.jsxs)("div",{children:[Object(u.jsx)("div",{style:{backgroundColor:"#375E65"}}),Object(u.jsx)("label",{children:"valor"})]}),1!==j.data.length?Object(u.jsxs)("div",{className:"teste ".concat(l?"active":""),onClick:function(){return d(!l)},children:[Object(u.jsx)("div",{className:"media",style:{backgroundColor:"#B14545"}}),Object(u.jsx)("label",{children:"m\xe9dia"})]}):null]})]})}function k(e){var t=e.dados;return Object(u.jsxs)("div",{className:"labelc",children:[Object(u.jsx)("label",{children:t.name}),Object(u.jsxs)("div",{children:[Object(u.jsx)("span",{className:"valor",children:t.data.reduce((function(e,t){return e+t.valor}),0)}),"Tempo m\xe9dio corre\xe7\xf5es OS de vazamento"===t.name?Object(u.jsx)("span",{className:"medida",children:"min"}):null]})]})}var z=a(372),A=a(77),M=a(188);function F(e){var t=e.dados;return Object(u.jsxs)("div",{className:"linec",children:[Object(u.jsx)("label",{children:"Gr\xe1fico em Linha"}),Object(u.jsx)(v.a,{width:"99%",height:324.5,children:Object(u.jsxs)(z.a,{data:t,margin:{top:30,right:-45,left:-20,bottom:5},children:[Object(u.jsx)(g.a,{}),Object(u.jsx)(N.a,{dataKey:"name",fontSize:"12",interval:0}),Object(u.jsx)(S.a,{yAxisId:"left",fontSize:"12"}),Object(u.jsx)(S.a,{yAxisId:"right",orientation:"right"}),Object(u.jsx)(w.a,{}),Object(u.jsx)(A.a,{}),Object(u.jsx)(M.a,{yAxisId:"left",type:"linear",dataKey:"N\xbaOS de Vazamento p/km de rede",stroke:"#B14545",activeDot:{stroke:"#B14545",strokeWidth:4},dot:{fill:"#B14545",r:4}}),Object(u.jsx)(M.a,{yAxisId:"left",type:"linear",dataKey:"N\xbaOS de Vazamento p/liga\xe7\xf5es",stroke:"#D9AE3F",activeDot:{stroke:"#D9AE3F",strokeWidth:4},dot:{fill:"#D9AE3F",r:4}}),Object(u.jsx)(M.a,{yAxisId:"left",type:"linear",dataKey:"Tempo m\xe9dio corre\xe7\xf5es OS de vazamento",stroke:"#629F64",activeDot:{stroke:"#629F64",strokeWidth:4},dot:{fill:"#629F64",r:4}})]})})]})}function R(e){var t=e.dados;return Object(u.jsxs)("div",{className:"tablec",children:[Object(u.jsx)("label",{children:"Sum\xe1rio"}),Object(u.jsx)("div",{children:Object(u.jsx)("table",{children:Object(u.jsx)("tbody",{children:t.map((function(e){return Object(u.jsxs)("tr",{children:[Object(u.jsx)("th",{children:e.name}),Object(u.jsxs)("td",{children:[e.valor," "]})]},e.name)}))})})})]})}var D=a(189),I=a.n(D).a.create({baseURL:"http://35.184.1.215:1680/api/v1/"});function T(){return Object(u.jsx)("div",{className:"content",children:Object(u.jsxs)("h1",{children:[Object(u.jsxs)("div",{className:"animatedLoading",children:[Object(u.jsx)("div",{className:"obj1"}),Object(u.jsx)("div",{className:"obj2"}),Object(u.jsx)("div",{className:"obj3"})]}),Object(u.jsx)("label",{className:"animatedText",children:"Carregando dados"})]})})}var H=a(38),B=a.p+"static/media/nodatamsg.8348335c.svg";function V(){var e=Object(n.useState)([]),t=Object(i.a)(e,2),a=t[0],c=t[1],s=Object(n.useState)([]),r=Object(i.a)(s,2),o=r[0],l=r[1],d=Object(n.useState)([]),j=Object(i.a)(d,2),b=j[0],O=j[1],m=Object(n.useState)(!0),h=Object(i.a)(m,2),v=h[0],x=h[1],g=Object(n.useState)([]),N=Object(i.a)(g,2),S=N[0],w=N[1],L=Object(H.c)((function(e){return e.data}));return Object(n.useEffect)((function(){x(!0)}),[L]),Object(n.useEffect)((function(){function e(){return(e=Object(p.a)(f.a.mark((function e(){var t;return f.a.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,I.post("perdas/Parametros",{CidadeId:10,Mes:parseInt(L.mes),Ano:parseInt(L.ano),Regiao:L.bairro});case 2:t=e.sent,w(t.data),x(!1);case 5:case"end":return e.stop()}}),e)})))).apply(this,arguments)}!function(){e.apply(this,arguments)}()}),[L]),Object(n.useEffect)((function(){var e=S.sort((function(e,t){return e.mes>t.mes?1:-1})),t=["JAN","FEV","MAR","ABR","MAI","JUN","JUL","AGO","SET","OUT","NOV","DEZ"],a={name:"N\xbaOS de Vazamento p/km de rede",data:e.map((function(e){var a=e.mes,n=e.vazamentosKMRDA;return{name:t[a-1],valor:n}})).reduce((function(e,t){var a=e.find((function(e){return e.name===t.name}));return a?a.valor+=t.valor:e.push(Object.assign({},t)),e}),[]).map((function(e){return{name:e.name,valor:parseFloat(Math.ceil(e.valor))}}))},n={name:"N\xbaOS de Vazamento p/liga\xe7\xf5es",data:e.map((function(e){var a=e.mes,n=e.vazamentoLigacoes;return{name:t[a-1],valor:n}})).reduce((function(e,t){var a=e.find((function(e){return e.name===t.name}));return a?a.valor+=t.valor:e.push(Object.assign({},t)),e}),[]).map((function(e){return{name:e.name,valor:parseFloat(Math.ceil(e.valor))}}))},s={name:"Tempo m\xe9dio corre\xe7\xf5es OS de vazamento",data:e.map((function(e){var a=e.mes,n=e.tempoMedioCorrecao;return{name:t[a-1],valor:n}})).reduce((function(e,t){var a=e.find((function(e){return e.name===t.name}));return a?a.valor+=t.valor/S.length:e.push(Object.assign({},t)),e}),[]).map((function(e){return{name:e.name,valor:parseFloat(e.valor.toFixed(2))}}))};console.log("dadoGrafico3"),console.log(s),c([a,n,s])}),[S]),Object(n.useEffect)((function(){if(a.length>1&&a[0].data.length>0){var e=a[0].data.map((function(e){return{name:e.name,"N\xbaOS de Vazamento p/km de rede":e.valor}})),t=a[1].data.map((function(e){return{name:e.name,"N\xbaOS de Vazamento p/liga\xe7\xf5es":e.valor}})),n=a[2].data.map((function(e){return{name:e.name,"Tempo m\xe9dio corre\xe7\xf5es OS de vazamento":e.valor}}));l(e.map((function(e,a){return Object.assign({},e,t[a])})).map((function(e,t){return Object.assign({},e,n[t])})));var c={name:"N\xbaOS de Vazamento p/km de rede",valor:a[0].data.reduce((function(e,t){return e+t.valor}),0)},s={name:"N\xbaOS de Vazamento p/liga\xe7\xf5es",valor:a[1].data.reduce((function(e,t){return e+t.valor}),0)},r={name:"Tempo m\xe9dio corre\xe7\xf5es OS de vazamento",valor:a[2].data.reduce((function(e,t){return e+t.valor}),0)},i={name:"Idade m\xe9dia hidrometros",valor:S.reduce((function(e,t){return e+t.idadeMediaHidrometros/S.length}),0)},o={name:"Infra\xe7\xf5es confirmadas",valor:S.reduce((function(e,t){return e+t.infracoesConfirmadas}),0)};O([c,s,r,i,o])}}),[a]),!0===v?Object(u.jsx)(T,{}):0===S.length&&!1===v?Object(u.jsx)("div",{className:"content",children:Object(u.jsxs)("h1",{className:"nodata",children:[Object(u.jsxs)("div",{children:[Object(u.jsx)("label",{children:"Oops!"}),Object(u.jsx)("label",{children:"Dados Indispon\xedveis"})]}),Object(u.jsx)("img",{src:B,alt:"No data"})]})}):Object(u.jsxs)("div",{className:"content",children:[Object(u.jsx)("div",{className:"content-top",children:a.map((function(e){return Object(u.jsxs)("div",{className:"twoinone",children:[Object(u.jsx)(k,{dados:e}),Object(u.jsx)(y,{dados:e})]},e.nome)}))}),Object(u.jsxs)("div",{className:"content-bottom",children:[Object(u.jsx)("div",{className:"lc",children:Object(u.jsx)(F,{dados:o})}),Object(u.jsx)("div",{className:"t",children:Object(u.jsx)(R,{dados:b})})]})]})}function W(e){var t=e.dados;return Object(u.jsxs)("div",{className:"barc",children:[Object(u.jsx)("label",{children:e.dados.name}),Object(u.jsx)(v.a,{height:237.5,children:Object(u.jsxs)(x.a,{data:t.data,margin:{top:30,right:0,left:-30,bottom:5},children:[Object(u.jsx)(g.a,{}),Object(u.jsx)(N.a,{dataKey:"name",fontSize:"12",interval:0}),Object(u.jsx)(S.a,{fontSize:"10"}),Object(u.jsx)(w.a,{}),Object(u.jsx)(L.a,{dataKey:"valor",fill:"#375E65"})]})})]})}function q(){var e=Object(n.useState)(!0),t=Object(i.a)(e,2),a=t[0],c=t[1],s=Object(n.useState)([]),r=Object(i.a)(s,2),o=r[0],l=r[1],d=Object(n.useState)([]),j=Object(i.a)(d,2),b=j[0],O=j[1],m=Object(n.useState)([]),h=Object(i.a)(m,2),v=h[0],x=h[1],g=Object(H.c)((function(e){return e.data}));return Object(n.useEffect)((function(){console.log(g),c(!0)}),[g]),Object(n.useEffect)((function(){function e(){return(e=Object(p.a)(f.a.mark((function e(){var t;return f.a.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return console.log(g),e.next=3,I.post("dadostecnicos/parametros",{CidadeId:10,Mes:parseInt(g.mes),Ano:parseInt(g.ano),Regiao:""});case 3:t=e.sent,x(t.data),c(!1);case 6:case"end":return e.stop()}}),e)})))).apply(this,arguments)}!function(){e.apply(this,arguments)}()}),[g]),Object(n.useEffect)((function(){for(var e=v.sort((function(e,t){return e.mes>t.mes?1:-1})),t=v.sort((function(e,t){return e.diametro>t.diametro?1:-1})),a=e.filter((function(e){if("A"===e.tipoDado)return e})),n=e.filter((function(e){if("E"===e.tipoDado)return e})),c=[],s=[],r=0;r<t.length;r++)c.includes(t[r].diametro)||c.push(t[r].diametro);for(r=0;r<c.length;r++)s.push({name:c[r],valor:0});for(r=0;r<a.length;r++)for(var i=0;i<s.length;i++)a[r].diametro===s[i].name&&(s[i].valor=s[i].valor+a[r].extensao);var o={name:"Extens\xe3o Rede Agua por Diametro",data:s},d=[],j=[];for(r=0;r<v.length;r++)d.includes(v[r].material)||d.push(v[r].material);for(r=0;r<d.length;r++)j.push({name:d[r],valor:0});for(r=0;r<a.length;r++)for(i=0;i<j.length;i++)a[r].material===j[i].name&&(j[i].valor=j[i].valor+a[r].extensao);var u={name:"Extens\xe3o Rede Agua por Material",data:j},b=[],m=[];for(r=0;r<v.length;r++)m.includes(v[r].tipo)||m.push(v[r].tipo);for(r=0;r<m.length;r++)b.push({name:m[r],valor:0});for(r=0;r<a.length;r++)for(i=0;i<b.length;i++)a[r].tipo===b[i].name&&(b[i].valor=b[i].valor+a[r].extensao);var h={name:"Extens\xe3o Rede Agua por Tipo",data:b},f=[];for(r=0;r<c.length;r++)f.push({name:c[r],valor:0});for(r=0;r<n.length;r++)for(i=0;i<f.length;i++)n[r].diametro===f[i].name&&(f[i].valor=f[i].valor+n[r].extensao);var p={name:"Extens\xe3o Rede Esgoto por Diametro",data:f},x=[];for(r=0;r<d.length;r++)x.push({name:d[r],valor:0});for(r=0;r<n.length;r++)for(i=0;i<x.length;i++)n[r].material===x[i].name&&(x[i].valor=x[i].valor+n[r].extensao);var g={name:"Extens\xe3o Rede Esgoto por Material",data:x},N=[];for(r=0;r<m.length;r++)N.push({name:m[r],valor:0});for(r=0;r<n.length;r++)for(i=0;i<N.length;i++)n[r].tipo===N[i].name&&(N[i].valor=N[i].valor+n[r].extensao);var S={name:"Extens\xe3o Rede Esgoto por Tipo",data:N};l([o,u,h]),O([p,g,S])}),[v]),a?Object(u.jsx)(T,{}):Object(u.jsxs)("div",{className:"content",children:[Object(u.jsx)("div",{className:"content-top",children:o.map((function(e){return Object(u.jsx)("div",{className:"twoinonedt",children:Object(u.jsx)(W,{dados:e})},e.name)}))}),Object(u.jsx)("div",{className:"content-top",children:b.map((function(e){return Object(u.jsx)("div",{className:"twoinonedt",children:Object(u.jsx)(W,{dados:e})},e.name)}))})]})}function P(e){var t=e.dados;return Object(u.jsxs)("div",{className:"labelos",children:[Object(u.jsx)("label",{children:t.name}),Object(u.jsxs)("div",{children:[Object(u.jsx)("span",{className:"valor",children:"Custo Medio"===t.name?t.data.toLocaleString("pt-br",{style:"currency",currency:"BRL"}):t.data}),"Tempo m\xe9dio corre\xe7\xf5es OS de vazamento"===t.name||"Tempo Medio"===t.name?Object(u.jsx)("span",{className:"medida",children:"min"}):null]})]})}function Z(){var e=Object(n.useState)(!0),t=Object(i.a)(e,2),a=t[0],c=t[1],s=Object(n.useState)([]),r=Object(i.a)(s,2),o=r[0],l=r[1],d=Object(n.useState)([]),j=Object(i.a)(d,2),b=j[0],O=j[1],m=Object(n.useState)([]),h=Object(i.a)(m,2),v=h[0],x=h[1],g=Object(n.useState)([]),N=Object(i.a)(g,2),S=N[0],w=N[1],L=Object(H.c)((function(e){return e.data}));return Object(n.useEffect)((function(){c(!0)}),[L]),Object(n.useEffect)((function(){function e(){return(e=Object(p.a)(f.a.mark((function e(){var t;return f.a.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,I.post("OrdemServicos/parametros",{CidadeId:10,natureza:L.natureza,equipe:L.equipe,Mes:parseInt(L.mes),Ano:parseInt(L.ano)});case 2:t=e.sent,O(t.data),c(!1);case 5:case"end":return e.stop()}}),e)})))).apply(this,arguments)}!function(){e.apply(this,arguments)}()}),[L]),Object(n.useEffect)((function(){if(b.length>0&&null!==b[0].mes){var e={name:"Quantidade OS",data:b.reduce((function(e,t){return e+t.qtdOS}),0)},t={name:"Quantidade OS no Prazo",data:b.reduce((function(e,t){return e+t.qtdOSPrazo}),0)},a={name:"Quantidade OS Fora do Prazo",data:b.reduce((function(e,t){return e+t.qtdOSForaPrazo}),0)},n={name:"Custo Medio",data:b.reduce((function(e,t){return e+t.custoMedio}),0)},c={name:"Distancia Media",data:b.reduce((function(e,t){return e+t.distanciaMedia}),0)},s={name:"Tempo Medio",data:b.reduce((function(e,t){return e+t.tempoMedio}),0)};l([e,t,a,n,c,s]),x(o.slice(0,3)),w(o.slice(-3))}}),[b]),a?Object(u.jsx)(T,{}):0===b.length&&!1===a?Object(u.jsx)("div",{className:"content",children:Object(u.jsxs)("h1",{className:"nodata",children:[Object(u.jsxs)("div",{children:[Object(u.jsx)("label",{children:"Oops!"}),Object(u.jsx)("label",{children:"Dados Indispon\xedveis"})]}),Object(u.jsx)("img",{src:B,alt:"No data"})]})}):Object(u.jsxs)("div",{className:"content",children:[Object(u.jsx)("div",{className:"content-top",children:v.map((function(e){return Object(u.jsx)("div",{className:"twoinone",children:Object(u.jsx)(P,{dados:e})},e.nome)}))}),Object(u.jsx)("div",{className:"content-top",children:S.map((function(e){return Object(u.jsx)("div",{className:"twoinone",children:Object(u.jsx)(P,{dados:e})},e.nome)}))})]})}function K(){var e=Object(n.useState)(""),t=Object(i.a)(e,2),a=t[0],c=t[1],s=Object(n.useState)(""),r=Object(i.a)(s,2),o=r[0],l=r[1],d=Object(n.useState)(""),j=Object(i.a)(d,2),b=j[0],O=j[1],m=Object(n.useState)(!1),h=Object(i.a)(m,2),f=h[0],p=h[1],v=Object(n.useState)(!1),x=Object(i.a)(v,2),g=x[0],N=x[1],S=Object(n.useState)(!1),w=Object(i.a)(S,2),L=w[0],C=w[1],E=Object(n.useState)(""),y=Object(i.a)(E,2),k=y[0],z=y[1],A=Object(n.useState)(""),M=Object(i.a)(A,2),F=M[0],R=M[1],D=Object(n.useState)(""),I=Object(i.a)(D,2),T=I[0],H=I[1];return Object(n.useEffect)((function(){""!==a&&(a.length>=4&&a.length<=15?p(!1):(p(!0),a.length<=15&&z("O nome deve ser maior que 4 caracteres!"),a.length>=4&&z("O nome deve ser menor que 16 caracteres!")))}),[a]),Object(n.useEffect)((function(){""!==o?(o.length>=6?N(!1):(N(!0),R("A senha deve conter pelo menos 6 caracteres!")),b===o||""===b?C(!1):(C(!0),H("As senhas digitadas n\xe3o coincidem!"))):N(!1)}),[o]),Object(n.useEffect)((function(){""!==b?b===o?C(!1):(C(!0),H("As senhas digitadas n\xe3o coincidem!")):C(!1)}),[b]),Object(u.jsx)("div",{className:"content",children:Object(u.jsxs)("div",{className:"config",children:[Object(u.jsxs)("div",{className:"tema",children:[Object(u.jsx)("label",{children:"Trocar tema"}),Object(u.jsxs)("div",{className:"tema-options",children:[Object(u.jsx)("input",{type:"radio",name:"tema",id:"claro",value:"claro",checked:!0}),Object(u.jsx)("label",{for:"claro",children:"Claro"}),Object(u.jsx)("input",{type:"radio",name:"tema",id:"escuro",value:"escuro"}),Object(u.jsx)("label",{for:"escuro",children:"Escuro"})]})]}),Object(u.jsxs)("div",{className:"atualizar-dados",children:[Object(u.jsx)("label",{children:"Alterar dados"}),Object(u.jsxs)("form",{className:"formulario",onSubmit:function(e){e.preventDefault();var t=3;switch(""!==a&&""===o&&""===b&&!1===f&&!1===g&&!1===L&&(t=0),""===a&&""!==o&&""!==b&&!1===f&&!1===g&&!1===L&&(t=1),""!==a&&""!==o&&""!==b&&!1===f&&!1===g&&!1===L&&(t=2),t){case 0:case 1:case 2:alert("comming soon...");break;case 3:alert("campos incorretos!")}},children:[Object(u.jsx)("label",{for:"nome",children:"Nome:"}),f?Object(u.jsx)("label",{className:"erro",children:k}):Object(u.jsxs)("label",{className:"erro",style:{opacity:"0"},children:[k,Object(u.jsx)("br",{})]}),Object(u.jsx)("input",{className:"campos",onBlur:function(e){c(e.target.value)},type:"text",id:"nome",placeholder:"Novo nome:"}),Object(u.jsx)("label",{for:"senha",children:"Senha:"}),g?Object(u.jsx)("label",{className:"erro",children:F}):Object(u.jsxs)("label",{className:"erro",style:{opacity:"0"},children:[F,Object(u.jsx)("br",{})]}),Object(u.jsx)("input",{className:"campos",onBlur:function(e){l(e.target.value)},type:"password",id:"senha",placeholder:"Nova senha:"}),L?Object(u.jsx)("label",{className:"erro",children:T}):Object(u.jsxs)("label",{className:"erro",style:{opacity:"0"},children:[T,Object(u.jsx)("br",{})]}),Object(u.jsx)("input",{className:"campos",onBlur:function(e){O(e.target.value)},type:"password",id:"confirmarSenha",placeholder:"Confirme a senha:"}),Object(u.jsx)("input",{className:"btnalterar",type:"submit",value:"Alterar"})]})]}),Object(u.jsx)("div",{className:"sair",children:Object(u.jsx)("input",{className:"btnsair",type:"button",value:"Sair",onClick:function(){}})})]})})}function U(e){return Object(u.jsxs)(l.c,{children:[Object(u.jsx)(b,{exact:!0,path:"/",component:m,isPrivate:!0}),Object(u.jsx)(b,{exact:!0,path:"/perdas",component:V,isPrivate:!0}),Object(u.jsx)(b,{exact:!0,path:"/dadostecnicos",component:q,isPrivate:!0}),Object(u.jsx)(b,{exact:!0,path:"/os",component:Z,isPrivate:!0}),Object(u.jsx)(b,{exact:!0,path:"/configuracoes",component:K,isPrivate:!0})]})}a(363);var G=a.p+"static/media/logo.5f0b9ed8.svg",J=a.p+"static/media/logomini.bce4787f.svg",_=a.p+"static/media/arrow-right.38d4714b.svg",Q=a.p+"static/media/arrow-left.fc06f99f.svg",X=a.p+"static/media/menu.ada9308c.svg";function Y(e,t){var a=Object(n.useState)({dynamicWidth:window.innerWidth,dynamicHeight:window.innerHeight}),c=Object(i.a)(a,2),s=c[0],r=c[1],o=function(){r({dynamicWidth:window.innerWidth,dynamicHeight:window.innerHeight})};Object(n.useEffect)((function(){return window.addEventListener("resize",o),function(){window.removeEventListener("resize",o)}}),[s]),Object(n.useEffect)((function(){if(s.dynamicWidth<1500)return window.addEventListener("resize",o),function(){window.removeEventListener("resize",o)}}),[]),Object(n.useEffect)((function(){if(s.dynamicWidth<1500){var a=function(a){e.current&&!e.current.contains(a.target)&&t(a)};return document.addEventListener("mousedown",a),document.addEventListener("touchstart",a),function(){document.removeEventListener("mousedown",a),document.removeEventListener("touchstart",a)}}}),[e,t])}var $=[{name:"Perdas",exact:!0,to:"/perdas",svg:Object(u.jsxs)("svg",{width:"30",height:"25",viewBox:"0 0 30 25",fill:"none",xmlns:"http://www.w3.org/2000/svg",children:[Object(u.jsx)("polygon",{fill:"#375E65",points:" 3,4 9,10.4379 9,25 3,25 3,4"}),Object(u.jsx)("polygon",{fill:"#375E65",points:" 13,9.29783 16,7 19,10.0639 19,25 13,25 13,9.29783"}),Object(u.jsx)("polygon",{fill:"#375E65",points:" 23,19 29,19 29,25 23,25 23,19"}),Object(u.jsx)("path",{d:"M9.29577 13.283L0 0L9.29577 8.30189L13.5211 4.15094L25.3521 15.3585L27.8873 12.8679L30 22L21.1268 19.9245L23.2394 17.8491L13.9437 9.13208L9.29577 13.283Z",fill:"#B14545"})]})},{name:"Dados T\xe9cnicos",to:"/dadostecnicos",svg:Object(u.jsxs)("svg",{width:"30",height:"29",viewBox:"0 0 30 29",fill:"none",xmlns:"http://www.w3.org/2000/svg",children:[Object(u.jsx)("rect",{x:"15",y:"0",width:"8",height:"3",rx:"2",stroke:"#375E65",strokeWidth:"2"}),Object(u.jsx)("rect",{x:"10",y:"2.93555",width:"18",height:"22.129",rx:"2",stroke:"#375E65",strokeWidth:"4"}),Object(u.jsx)("path",{fillRule:"evenodd",clipRule:"evenodd",d:"M10.3125 10.6128H12.6875L13.3413 13.1436C13.9957 13.3126 14.6131 13.5694 15.179 13.9003L17.4622 12.5746L19.1416 14.1998L17.7355 16.4677C18.014 16.9536 18.2335 17.4755 18.3848 18.0244L21 18.6571V20.9555L18.3848 21.5882C18.2142 22.2071 17.9569 22.7916 17.6263 23.329L19.1417 25.7734L17.4623 27.3986L14.8606 25.8879C14.384 26.1351 13.875 26.3313 13.3413 26.4691L12.6875 28.9999H10.3125L9.6587 26.4691C9.09151 26.3226 8.55218 26.1102 8.05002 25.8407L5.70657 27.2014L4.02719 25.5762L5.39707 23.3666C5.05517 22.8189 4.78978 22.2215 4.61521 21.5882L2 20.9555V18.6571L4.6152 18.0244C4.77055 17.4609 4.99782 16.9257 5.28691 16.4288L4.02719 14.397L5.70657 12.7718L7.73652 13.9505C8.32532 13.5953 8.97157 13.3211 9.6587 13.1437L10.3125 10.6128ZM11.5 23.2539C13.4675 23.2539 15.0625 21.7104 15.0625 19.8063C15.0625 17.9023 13.4675 16.3588 11.5 16.3588C9.53249 16.3588 7.9375 17.9023 7.9375 19.8063C7.9375 21.7104 9.53249 23.2539 11.5 23.2539Z",fill:"#D9AE3F"}),Object(u.jsx)("path",{fillRule:"evenodd",clipRule:"evenodd",d:"M6.09991 2.87109L7.43529 3.17777L7.45396 4.6852C7.79863 4.8647 8.11034 5.08884 8.38293 5.34796L9.84949 4.89737L10.5697 6.02802L9.46638 7.12161C9.55593 7.43081 9.6074 7.75262 9.61679 8.08078L11 8.77423L10.6831 10.0665L9.12541 10.0846C8.94418 10.4105 8.71891 10.706 8.4589 10.9654L8.97395 12.5355L7.80561 13.2324L6.55104 12.0471C6.24898 12.1245 5.93572 12.1691 5.61665 12.1777L4.90009 13.5163L3.56471 13.2096L3.54604 11.7021C3.24732 11.5466 2.97336 11.3575 2.72817 11.1411L1.22291 11.6036L0.502727 10.473L1.57762 9.40746C1.4609 9.05536 1.39405 8.6852 1.38321 8.30657L0 7.61312L0.3169 6.32081L1.87458 6.30275C2.03963 6.00595 2.2412 5.7344 2.47227 5.49229L2.04411 4.18722L3.21246 3.49027L4.19132 4.41513C4.57134 4.29148 4.97253 4.22071 5.38334 4.2097L6.09991 2.87109ZM5.02465 10.1321C6.13092 10.3862 7.24055 9.72428 7.50308 8.65369C7.76561 7.5831 7.08162 6.50927 5.97535 6.25521C4.86908 6.00115 3.75945 6.66307 3.49692 7.73366C3.23439 8.80425 3.91838 9.87808 5.02465 10.1321Z",fill:"#D9AE3F"})]})},{name:"Ordem de Servi\xe7o",to:"/os",svg:Object(u.jsxs)("svg",{width:"28",height:"30",viewBox:"0 0 28 30",fill:"none",xmlns:"http://www.w3.org/2000/svg",children:[Object(u.jsx)("rect",{x:"1.5",y:"2.06885",width:"2",height:"25",rx:"2.07407",stroke:"#375E65",strokeWidth:"3"}),Object(u.jsx)("path",{d:"M19.9322 3.35286C20.4068 -3.85683 2.0565 2.57493 0 4.0953V24.8276C1.58192 23.169 12.339 15.2274 17.5593 22.013C20.5653 25.9202 22.7797 19.8925 28 23.2853V7.59373C24.2034 4.0953 19.5699 8.8565 19.9322 3.35286Z",fill:"#629F64"})]})}],ee=function(e){var t=Object(n.useState)(!1),a=Object(i.a)(t,2),c=a[0],s=a[1],r=Object(n.useState)(!1),d=Object(i.a)(r,2),j=d[0],b=d[1],O=Object(n.useState)("Home"),m=Object(i.a)(O,2),h=m[0],f=m[1],p=Object(n.useRef)(),v=Object(n.useState)(""),x=Object(i.a)(v,2),g=(x[0],x[1]),N=Object(n.useState)({dynamicWidth:window.innerWidth,dynamicHeight:window.innerHeight}),S=Object(i.a)(N,2),w=S[0],L=S[1],C=function(){L({dynamicWidth:window.innerWidth,dynamicHeight:window.innerHeight})};function E(){s(!c),b(!j)}Object(n.useEffect)((function(){return window.addEventListener("resize",C),function(){window.removeEventListener("resize",C)}}),[w]),Object(n.useEffect)((function(){s(!c)}),[w.dynamicWidth<1500]),Y(p,(function(){return s(!0)})),Object(n.useEffect)((function(){e.onCollapse(c)}),[c]),Object(n.useEffect)((function(){e.onCollapse(j)}),[j]);var y=Object(l.g)();return Object(n.useEffect)((function(){"/"===y.pathname&&f("Home"),"/perdas"===y.pathname&&f("Perdas"),"/dadostecnicos"===y.pathname&&f("Dados T\xe9cnicos"),"/os"===y.pathname&&f("Ordem de Servi\xe7o"),"/configuracoes"===y.pathname&&f("Configura\xe7\xf5es")}),[y]),Object(n.useEffect)((function(){g((new Date).getTime().toString())}),[]),Object(u.jsxs)("div",{ref:p,className:"side-menu ".concat(c?"inactive":""),children:[Object(u.jsxs)("div",{className:"drawer",children:[Object(u.jsx)("img",{src:X,alt:"show",onClick:function(){return E()}}),Object(u.jsx)("label",{children:h})]}),Object(u.jsxs)("div",{className:"side",children:[Object(u.jsx)("div",{className:"logo",children:c?Object(u.jsx)("img",{src:J,alt:"celtica"}):Object(u.jsx)("img",{src:G,alt:"celtica"})}),Object(u.jsx)("div",{className:"hello",children:Object(u.jsx)("i",{})}),Object(u.jsx)("div",{className:"main-menu",children:Object(u.jsxs)("ul",{children:[$.map((function(t,a){return Object(u.jsx)("li",{onClick:e.onClick,children:Object(u.jsxs)(o.b,{name:t.name,exact:!0,to:t.to,className:"menu-item",children:[Object(u.jsx)("div",{className:"menu-icon",children:t.svg}),Object(u.jsx)("span",{children:t.name})]},a)},a)})),Object(u.jsxs)("li",{onClick:function(e){window.location.replace("/")},value:e.logged,children:[Object(u.jsx)("div",{className:"menu-icon",children:Object(u.jsxs)("svg",{width:"30",height:"30",viewBox:"0 0 30 30",fill:"none",xmlns:"http://www.w3.org/2000/svg",children:[Object(u.jsx)("path",{d:"M2 3.32127L14 2.19627L14 27.8711L2 27.1211L2 3.32127Z",fill:"#375E65",stroke:"#375E65","stroke-width":"4"}),Object(u.jsx)("path",{d:"M20 5H13V1H22C23.1046 1 24 1.89543 24 3V6C24 6.55228 23.5523 7 23 7H21C20.4477 7 20 6.55228 20 6V5Z",fill:"#375E65"}),Object(u.jsx)("path",{d:"M20 25H13V29H22C23.1046 29 24 28.1046 24 27V24C24 23.4477 23.5523 23 23 23H21C20.4477 23 20 23.4477 20 24V25Z",fill:"#375E65"}),Object(u.jsx)("circle",{cx:"11",cy:"16",r:"2",fill:"white"}),Object(u.jsx)("path",{"fill-rule":"evenodd","clip-rule":"evenodd",d:"M24 9.87868L29.0607 13.8788C29.6464 14.4646 29.6464 15.4143 29.0607 16.0001L24 20.0609C23.4142 20.6467 22.4645 20.6467 21.8787 20.0609C21.2929 19.4751 21.2929 18.5254 21.8787 17.9396L24.3787 16.4395H18V13.4395H24.3787L21.8787 12C21.2929 11.4142 21.2929 10.4645 21.8787 9.87868C22.4645 9.29289 23.4142 9.29289 24 9.87868Z",fill:"#375E65"})]})}),Object(u.jsx)("span",{children:"Sair"})]})]})}),Object(u.jsx)("div",{onClick:function(){return E()},className:"toggle-menu-btn",children:c?Object(u.jsx)("img",{src:_,alt:"expandir"}):Object(u.jsx)("img",{src:Q,alt:"retrair"})})]})]})},te=a.p+"static/media/filtro.7450799f.svg",ae=a.p+"static/media/close.c8899d6e.svg";function ne(e,t){var a=Object(n.useRef)(),c=Object(l.g)(),s=Object(n.useState)(!0),r=Object(i.a)(s,2),o=r[0],d=r[1],j=Object(n.useState)(!0),b=Object(i.a)(j,2),O=b[0],m=b[1],h=Object(n.useState)([]),v=Object(i.a)(h,2),x=v[0],g=v[1],N=Object(n.useState)([]),S=Object(i.a)(N,2),w=S[0],L=S[1],C=Object(n.useState)([]),E=Object(i.a)(C,2),y=E[0],k=E[1],z=Object(n.useState)([]),A=Object(i.a)(z,2),M=A[0],F=A[1],R=Object(n.useState)([]),D=Object(i.a)(R,2),T=D[0],B=D[1],V=Object(n.useState)("0"),W=Object(i.a)(V,2),q=W[0],P=W[1],Z=Object(n.useState)(""),K=Object(i.a)(Z,2),U=K[0],G=K[1],J=Object(n.useState)("0"),_=Object(i.a)(J,2),Q=_[0],X=_[1],$=Object(n.useState)(""),ee=Object(i.a)($,2),ne=ee[0],ce=ee[1],se=Object(n.useState)(""),re=Object(i.a)(se,2),ie=re[0],oe=re[1],le=Object(n.useState)([]),de=Object(i.a)(le,2),je=de[0],ue=(de[1],Object(n.useState)([])),be=Object(i.a)(ue,2),Oe=be[0],me=be[1],he=Object(l.f)();Object(n.useEffect)((function(){return he.listen((function(e){if("/perdas"===e.pathname&&me("perdas/Filtro/10"),"/dadostecnicos"===e.pathname&&me("dadostecnicos/Filtro/10"),"/os"===e.pathname&&me("ordemservicos/Filtro/10"),x.length>0){var t=x[0].label;P(t),fe({type:"CHANGE_FILTRO",data:{ano:t,bairro:U,mes:Q}})}}))}),[he]);var fe=Object(H.b)(),pe=["JANEIRO","FEVEREIRO","MAR\xc7O","ABRIL","MAIO","JUNHO","JULHO","AGOSTO","SETEMBRO","OUTUBRO","NOVEMBRO","DEZEMBRO"];function ve(e){P(e.target.value)}function xe(e){G(e.target.value)}function ge(e){X(e.target.value)}function Ne(e){ce(e.target.value)}function Se(e){oe(e.target.value)}return Object(n.useEffect)((function(){function e(){return(e=Object(p.a)(f.a.mark((function e(){var t,a;return f.a.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return m(!0),he.listen((function(e){"/perdas"===e.pathname&&me("perdas/Filtro/10"),"/dadostecnicos"===e.pathname&&me("dadostecnicos/Filtro/10"),"/os"===e.pathname&&me("ordemservicos/Filtro/10")})),e.next=4,I.get("".concat(Oe));case 4:t=e.sent,g(t.data.ano.map((function(e){return{label:e}})).sort((function(e,t){return e.label<t.label?1:-1}))),k(pe.map((function(e,t){return{label:e,value:"".concat(t+1)}}))),"perdas"===(a=Oe.split("/").shift())&&L(t.data.regioes.map((function(e){return{label:e}}))),"ordemservicos"===a&&(F(t.data.equipe.map((function(e){return{label:e}}))),B(t.data.natureza.map((function(e){return{label:e}})))),m(!1);case 11:case"end":return e.stop()}}),e)})))).apply(this,arguments)}!function(){e.apply(this,arguments)}()}),[Oe]),Object(n.useEffect)((function(){if(x.length>0){var e=x[0].label;P(e),G(""),X("0"),ce(""),oe(""),fe({type:"CHANGE_FILTRO",data:{ano:e,bairro:U,mes:Q,equipe:ne,natureza:ie}})}}),[O]),Y(a,(function(){return d(!0)})),Object(n.useEffect)((function(){e.onCollapse(o)}),[o]),"/"===c.pathname||"/configuracoes"===c.pathname?null:Object(u.jsxs)("form",{ref:a,className:"filtro ".concat(o?"inactiveFilter":""),onSubmit:function(e){e.preventDefault(),fe({type:"CHANGE_FILTRO",data:{ano:q,bairro:U,mes:Q,equipe:ne,natureza:ie}})},children:[o?Object(u.jsx)("img",{src:te,alt:"Filtro",onClick:function(){return d(!o)}}):Object(u.jsx)("img",{src:te,alt:"Filtro"}),Object(u.jsx)("img",{className:"fechar",src:ae,alt:"Fechar",onClick:function(){return d(!o)}}),Object(u.jsx)("label",{children:"Filtros"}),Object(u.jsx)("br",{}),O?null:Object(u.jsxs)("div",{className:"campos",children:[Object(u.jsxs)("div",{children:[Object(u.jsx)("label",{className:"title",children:"Ano:"}),Object(u.jsx)("select",{name:"ano",id:"ano",onBlur:ve,onChange:ve,value:q,select:je.ano,children:x.map((function(e){return Object(u.jsx)("option",{value:e.label,children:e.label},e.label)}))})]}),"/perdas"!==c.pathname?null:Object(u.jsxs)("div",{children:[Object(u.jsx)("label",{className:"title",children:"Bairro:"}),Object(u.jsxs)("select",{name:"bairro",id:"bairro",onLoad:xe,onChange:xe,value:U,select:je.bairro,children:[Object(u.jsx)("option",{value:"",children:"TODOS"}),w.map((function(e){return Object(u.jsx)("option",{value:e.label,children:e.label},e.label)}))]})]}),Object(u.jsxs)("div",{children:[Object(u.jsx)("label",{className:"title",children:"M\xeas:"}),Object(u.jsxs)("select",{name:"mes",id:"mes",onLoad:ge,onChange:ge,value:Q,select:je.mes,children:[Object(u.jsx)("option",{value:"0",children:"TODOS"}),y.map((function(e){return Object(u.jsx)("option",{value:e.value,children:e.label},e.label)}))]})]}),"/os"!==c.pathname?null:Object(u.jsxs)("div",{children:[Object(u.jsx)("label",{className:"title",children:"Equipe:"}),Object(u.jsxs)("select",{name:"equipe",id:"equipe",onLoad:Ne,onChange:Ne,value:ne,select:je.equipe,children:[Object(u.jsx)("option",{value:"",children:"TODAS"}),M.map((function(e){return Object(u.jsx)("option",{value:e.label,children:e.label},e.label)}))]})]}),"/os"!==c.pathname?null:Object(u.jsxs)("div",{children:[Object(u.jsx)("label",{className:"title",children:"Natureza:"}),Object(u.jsxs)("select",{name:"natureza",id:"natureza",onLoad:Se,onChange:Se,value:ie,select:je.natureza,children:[Object(u.jsx)("option",{value:"",children:"TODAS"}),T.map((function(e){return Object(u.jsx)("option",{value:e.label,children:e.label},e.label)}))]})]}),Object(u.jsx)("input",{type:"submit",value:"Filtrar",className:"btnfiltrar"})]})]})}function ce(){return Object(u.jsx)("div",{className:"drawer"})}var se=a(192),re={data:{ano:"",regiao:"",mes:"0",natureza:"",equipe:""}};var ie=Object(se.a)((function(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:re,t=arguments.length>1?arguments[1]:void 0;switch(t.type){case"CHANGE_FILTRO":return{data:t.data};default:return e}})),oe=(a(364),a.p+"static/media/eye-open.2d3e0f90.svg"),le=a.p+"static/media/eye-close.300635cb.svg";var de=function(e){var t=Object(n.useState)(""),a=Object(i.a)(t,2),c=a[0],s=a[1],r=Object(n.useState)(""),o=Object(i.a)(r,2),l=o[0],d=o[1],j=Object(n.useState)(!1),b=Object(i.a)(j,2),O=b[0],m=b[1],h=Object(n.useState)("password"),v=Object(i.a)(h,2),x=(v[0],v[1]);function g(){return(g=Object(p.a)(f.a.mark((function t(a){var n;return f.a.wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return a.preventDefault(),t.next=3,I.post("Auth/login",{username:c,password:l});case 3:n=t.sent,""!=n.data.token?e.onSubmit(!0):alert("usuario e/ou senha incorretos!");case 6:case"end":return t.stop()}}),t)})))).apply(this,arguments)}return Object(u.jsx)("div",{className:"container",children:Object(u.jsx)("div",{className:"container-login",children:Object(u.jsxs)("div",{className:"wraper-login",children:[Object(u.jsxs)("form",{className:"login-form",onSubmit:function(e){return function(e){return g.apply(this,arguments)}(e)},value:e.logged,children:[Object(u.jsx)("span",{className:"login-form-title",children:Object(u.jsx)("img",{src:G,alt:"C\xe9ltica"})}),Object(u.jsxs)("div",{className:"wraper-input",children:[Object(u.jsx)("input",{className:""!=c?"has-val input":"input",type:"text",value:c,onChange:function(e){s(e.target.value)}}),Object(u.jsx)("span",{className:"focus-input","data-placeholder":"Usu\xe1rio"})]}),Object(u.jsxs)("div",{className:"wraper-input",children:[Object(u.jsx)("input",{className:""!=l?"has-val input":"input",type:0==O?"password":"text",value:l,onChange:function(e){d(e.target.value)}}),Object(u.jsx)("span",{className:"focus-input","data-placeholder":"Senha"}),Object(u.jsx)("div",{children:Object(u.jsx)("img",{className:"eye",onClick:function(){O?(m(!1),x("password")):(m(!0),x("text"))},width:"20px",src:0==O?le:oe,alt:"Mostrar senha"})})]}),Object(u.jsx)("div",{className:"container-login-form-btn",children:Object(u.jsx)("button",{className:"login-form-btn",children:"Login"})})]}),Object(u.jsxs)("div",{className:"account-info",children:[Object(u.jsx)("span",{className:"info1",children:"N\xe3o consegue acessar o sistema?"}),Object(u.jsx)("a",{className:"info2",href:"#",children:"Fale Conosco."})]})]})})})};var je=function(){Object(n.useRef)();var e=Object(n.useState)(!1),t=Object(i.a)(e,2),a=(t[0],t[1]),c=Object(n.useState)(!1),s=Object(i.a)(c,2),r=(s[0],s[1]),l=Object(n.useState)(!1),d=Object(i.a)(l,2),j=d[0],b=d[1];function O(e){b(e)}return Object(u.jsx)("div",{className:"app",children:Object(u.jsx)(H.a,{store:ie,children:Object(u.jsx)(o.a,{children:j?Object(u.jsxs)(u.Fragment,{children:[Object(u.jsx)(ee,{onCollapse:function(e){a(e)}}),Object(u.jsx)(ce,{}),Object(u.jsxs)("div",{className:"container",children:[Object(u.jsx)(ne,{onCollapse:function(e){r(e)}}),Object(u.jsx)(U,{value:j,onCollapse:O})]})]}):Object(u.jsx)(de,{value:j,onSubmit:O})})})})};r.a.render(Object(u.jsx)(c.a.StrictMode,{children:Object(u.jsx)(je,{})}),document.getElementById("root"))}},[[365,1,2]]]);
//# sourceMappingURL=main.92e88b2f.chunk.js.map