package com.mutiny.models;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "tbl_notification_types")
public class NotificationType {

	@Id
	@Column(name = "type_id")
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int typeId;

	@Column(name = "type_name")
	private String typeName;

	public NotificationType() {
		super();
	}

	public NotificationType(String typeName) {
		super();
		this.typeName = typeName;
	}

	public int getTypeId() {
		return typeId;
	}

	public void setTypeId(int typeId) {
		this.typeId = typeId;
	}

	public String getTypeName() {
		return typeName;
	}

	public void setTypeName(String typeName) {
		this.typeName = typeName;
	}

	@Override
	public String toString() {
		return "NotificationType [typeId=" + typeId + ", typeName=" + typeName + "]";
	}
	
}
