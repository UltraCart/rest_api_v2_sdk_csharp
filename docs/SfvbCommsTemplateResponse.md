
# com.ultracart.admin.v2.Model.SfvbCommsTemplateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerCjson** | **string** | The template&#39;s body, as CJSON. | [optional] 
**EmailTemplateVmPath** | **string** | The Velocity template it renders inside, as stored.  It is looked up in the storefront&#39;s active theme. | [optional] 
**Notes** | **List&lt;string&gt;** | What isn&#39;t shown. | [optional] 
**Template** | [**SfvbCommsTemplate**](SfvbCommsTemplate.md) |  | [optional] 
**TemplateExists** | **bool** | True when the file at template_path exists. | [optional] 
**TemplateNote** | **string** | Why there is no template file, or null when there is one. | [optional] 
**TemplatePath** | **string** | The theme file that template is, as a render finds it.  Read it with the files endpoints, whose read also reports valid and velocity_errors.  Null when it couldn&#39;t be worked out, with template_note saying why. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

