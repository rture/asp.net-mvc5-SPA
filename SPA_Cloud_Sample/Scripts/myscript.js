﻿//$(document).ready(function () {
//    $('#addContact').bootstrapValidator({
//        message: 'This value is not valid',
//        feedbackIcons: {
//            valid: 'glyphicon glyphicon-ok',
//            invalid: 'glyphicon glyphicon-remove',
//            validating: 'glyphicon glyphicon-refresh'
//        },
//        fields: {
//            Name: {
//                message: 'The username is not valid',
//                validators: {
//                    notEmpty: {
//                        message: 'The username is required and cannot be empty'
//                    },
//                    stringLength: {
//                        min: 6,
//                        max: 30,
//                        message: 'The username must be more than 6 and less than 30 characters long'
//                    },
//                    regexp: {
//                        regexp: /^[a-zA-Z0-9_]+$/,
//                        message: 'The username can only consist of alphabetical, number and underscore'
//                    }
//                }
//            },
//            Email: {
//                validators: {
//                    notEmpty: {
//                        message: 'The email is required and cannot be empty'
//                    },
//                    EmailAddress: {
//                        message: 'The input is not a valid email address'
//                    }
//                }
//            }
//        }
//    });
//});