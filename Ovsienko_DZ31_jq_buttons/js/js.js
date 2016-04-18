// JavaScript Document
$('#btn1').click(function(){
$('#btn2').css('background', '#00ffff');
$('#btn2').css('width', '60px');
$('#btn2').css('height', '60px');
});
$('#btn2').click(function(){
$('#btn2').css('background', '#11fa06');
$('#btn2').css('width', '50px');
$('#btn2').css('height', '50px');
$('#btn1').css('background', '#ff9900');
$('#btn1').css('width', '60px');
$('#btn1').css('height', '60px');
$('#btn3').css('visibility', 'visible');
});
$('#btn3').click(function(){
$('#btn1').css('background', '#ffff00');
$('#btn1').css('width', '50px');
$('#btn1').css('height', '50px');
$('#btn3').css('visibility', 'hidden');
});